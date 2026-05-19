using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Database;
using Clinic_System.Models;

namespace Clinic_System.Forms
{
    public partial class MedicineForm : Form
    {
        private int selectedMedicineId = -1; // tracks which row is selected
        public MedicineForm()
        {
            InitializeComponent();
            LoadMedicines();
        }

        // ─────────────────────────────────────────
        // LOAD ALL MEDICINES INTO DATAGRIDVIEW
        // ─────────────────────────────────────────
        private void LoadMedicines(string search = "")
        {
            dgvMedicines.Rows.Clear();
            dgvMedicines.Columns.Clear();

            dgvMedicines.Columns.Add("Id", "ID");
            dgvMedicines.Columns.Add("Name", "Medicine Name");
            dgvMedicines.Columns.Add("Quantity", "Quantity");
            dgvMedicines.Columns.Add("Price", "Price (Rs.)");
            dgvMedicines.Columns.Add("Expiry", "Expiry Date");

            dgvMedicines.Columns["Id"].Visible = false;

            // All data comes from MedicineRepository — no SQL here!
            List<Medicine> medicines = MedicineRepository.GetAllMedicines(search);

            foreach (Medicine m in medicines)
            {
                dgvMedicines.Rows.Add(
                    m.Id,
                    m.Name,
                    m.Quantity,
                    m.Price.ToString("F2"),
                    m.ExpiryDate
                );
            }
        }

        // ─────────────────────────────────────────
        // ADD MEDICINE
        // ─────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Medicine medicine = new Medicine
            {
                Name = txtName.Text.Trim(),
                Quantity = int.Parse(txtQty.Text.Trim()),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                ExpiryDate = txtExpiry.Text.Trim()
            };

            if (MedicineRepository.AddMedicine(medicine))
            {
                MessageBox.Show("Medicine added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMedicines();
            }
        }
        // ─────────────────────────────────────────
        // UPDATE MEDICINE
        // ─────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == -1)
            {
                MessageBox.Show("Please select a medicine to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            Medicine medicine = new Medicine
            {
                Id = selectedMedicineId,
                Name = txtName.Text.Trim(),
                Quantity = int.Parse(txtQty.Text.Trim()),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                ExpiryDate = txtExpiry.Text.Trim()
            };

            if (MedicineRepository.UpdateMedicine(medicine))
            {
                MessageBox.Show("Medicine updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMedicines();
            }
        }

        // ─────────────────────────────────────────
        // DELETE MEDICINE
        // ─────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMedicineId == -1)
            {
                MessageBox.Show("Please select a medicine to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this medicine?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (MedicineRepository.DeleteMedicine(selectedMedicineId))
                {
                    MessageBox.Show("Medicine deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadMedicines();
                }
            }
        }
        // ─────────────────────────────────────────
        // SEARCH MEDICINE
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMedicines(txtSearch.Text.Trim());
        }
        // ─────────────────────────────────────────
        // CLICK ROW IN DATAGRIDVIEW → FILL FIELDS
        // ─────────────────────────────────────────
        private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicines.Rows[e.RowIndex];
                selectedMedicineId = int.Parse(row.Cells["Id"].Value.ToString());
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtQty.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtExpiry.Text = row.Cells["Expiry"].Value.ToString();
            }
        }
        // ─────────────────────────────────────────
        // CLEAR BUTTON
        // ─────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        // ─────────────────────────────────────────
        // HELPER METHODS
        // ─────────────────────────────────────────
        private void ClearFields()
        {
            txtName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtExpiry.Clear();
            selectedMedicineId = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter medicine name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                MessageBox.Show("Please enter quantity!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Please enter price!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
