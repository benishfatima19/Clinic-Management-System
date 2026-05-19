using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Clinic_System.Database;
using Clinic_System.Models;

namespace Clinic_System.Forms
{
    public partial class BillingForm : Form
    {
        // Holds medicines added to current bill
        private List<BillItem> billItems = new List<BillItem>();
        private decimal totalAmount = 0;
        public BillingForm()
        {
            InitializeComponent();
            LoadPatients();
            LoadMedicines();
            SetupGrid();
        }

        // ─────────────────────────────────────────
        // SETUP DATAGRIDVIEW COLUMNS
        // ─────────────────────────────────────────
        private void SetupGrid()
        {
            dgvBillItems.Columns.Clear();
            dgvBillItems.Columns.Add("MedicineName", "Medicine");
            dgvBillItems.Columns.Add("Quantity", "Quantity");
            dgvBillItems.Columns.Add("Price", "Unit Price");
            dgvBillItems.Columns.Add("Subtotal", "Subtotal");
        }

        // ─────────────────────────────────────────
        // LOAD PATIENTS INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadPatients()
        {
            cmbPatient.Items.Clear();
            cmbPatient.Items.Add(new ComboItem(0, "-- Select Patient --"));
            cmbPatient.SelectedIndex = 0;

            // PatientRepository handles database — no SQL here!
            List<Patient> patients = PatientRepository.GetAllPatientsForDropdown();
            foreach (Patient p in patients)
                cmbPatient.Items.Add(new ComboItem(p.Id, p.Name));
        }

        // ─────────────────────────────────────────
        // LOAD MEDICINES INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadMedicines()
        {
            cmbMedicine.Items.Clear();
            cmbMedicine.Items.Add(new ComboItem(0, "-- Select Medicine --", 0));
            cmbMedicine.SelectedIndex = 0;

            // Only load medicines that are in stock
            List<Medicine> medicines = MedicineRepository.GetMedicinesInStock();
            foreach (Medicine m in medicines)
                cmbMedicine.Items.Add(new ComboItem(m.Id, m.Name, m.Price));
        }
        // ─────────────────────────────────────────
        // ADD ITEM TO BILL
        // ─────────────────────────────────────────
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a patient!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMedicine.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a medicine!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                MessageBox.Show("Please enter quantity!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboItem selectedMedicine = (ComboItem)cmbMedicine.SelectedItem;

            // Check stock using MedicineRepository
            int availableStock = MedicineRepository.GetMedicineStock(selectedMedicine.Id);
            if (qty > availableStock)
            {
                MessageBox.Show($"Not enough stock! Available: {availableStock}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if medicine already added to bill
            foreach (BillItem existing in billItems)
            {
                if (existing.MedicineId == selectedMedicine.Id)
                {
                    MessageBox.Show("This medicine is already added!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Add to bill items list
            billItems.Add(new BillItem
            {
                MedicineId = selectedMedicine.Id,
                MedicineName = selectedMedicine.Name,
                Quantity = qty,
                Price = selectedMedicine.Price
            });

            RefreshGrid();
            txtQty.Clear();
            cmbMedicine.SelectedIndex = 0;
        }
        
        // ─────────────────────────────────────────
        // REMOVE ITEM FROM BILL
        // ─────────────────────────────────────────
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvBillItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvBillItems.SelectedRows[0].Index;
            billItems.RemoveAt(index);
            RefreshGrid();
        }
        // ─────────────────────────────────────────
        // GENERATE AND SAVE BILL
        // ─────────────────────────────────────────
        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a patient!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (billItems.Count == 0)
            {
                MessageBox.Show("Please add at least one medicine!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Generate bill for Rs. {totalAmount:F2}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ComboItem selectedPatient = (ComboItem)cmbPatient.SelectedItem;

                // BillRepository handles all database logic — no SQL here!
                int billId = BillRepository.GenerateBill(
                    selectedPatient.Id,
                    totalAmount,
                    billItems
                );

                if (billId > 0)
                {
                    MessageBox.Show(
                        $"Bill generated successfully!\nBill ID: {billId}\nTotal: Rs. {totalAmount:F2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearAll();
                    LoadMedicines(); // Refresh to show updated stock
                }
            }
        }
        // ─────────────────────────────────────────
        // CLEAR BUTTON
        // ─────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        // ─────────────────────────────────────────
        // HELPER METHODS
        // ─────────────────────────────────────────
        private void RefreshGrid()
        {
            dgvBillItems.Rows.Clear();
            totalAmount = 0;

            foreach (BillItem item in billItems)
            {
                dgvBillItems.Rows.Add(
                    item.MedicineName,
                    item.Quantity,
                    $"Rs. {item.Price:F2}",
                    $"Rs. {item.Subtotal:F2}"
                );
                totalAmount += item.Subtotal;
            }

            lblTotalValue.Text = $"Rs. {totalAmount:F2}";
        }

        private void ClearAll()
        {
            billItems.Clear();
            dgvBillItems.Rows.Clear();
            totalAmount = 0;
            lblTotalValue.Text = "Rs. 0.00";
            cmbPatient.SelectedIndex = 0;
            cmbMedicine.SelectedIndex = 0;
            txtQty.Clear();
        }
    }

    // ─────────────────────────────────────────
    // HELPER CLASS FOR COMBOBOX ITEMS
    // ─────────────────────────────────────────
    /// <summary>
    /// Helper class used by ComboBoxes in Billing form.
    /// Stores Id, Name and Price for each dropdown item.
    /// </summary>
    public class ComboItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ComboItem(int id, string name, decimal price = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
