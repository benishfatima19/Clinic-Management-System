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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadBillingReport();
            LoadInventoryReport();
        }
        // ─────────────────────────────────────────
        // BILLING REPORT
        // ─────────────────────────────────────────

        private void LoadBillingReport(string search = "")
        {
            dgvBills.Rows.Clear();
            dgvBills.Columns.Clear();

            dgvBills.Columns.Add("BillId", "Bill ID");
            dgvBills.Columns.Add("Patient", "Patient Name");
            dgvBills.Columns.Add("Date", "Date");
            dgvBills.Columns.Add("Total", "Total (Rs.)");

            // BillRepository handles all SQL — no SQL here!
            List<Bill> bills = BillRepository.GetAllBills(search);

            decimal totalRevenue = 0;
            foreach (Bill b in bills)
            {
                dgvBills.Rows.Add(
                    b.Id,
                    b.PatientName,
                    b.Date,
                    $"Rs. {b.Total:F2}"
                );
                totalRevenue += b.Total;
            }

            lblTotalRevenue.Text = $"Total Revenue: Rs. {totalRevenue:F2}";
            lblTotalRevenue.ForeColor = Color.Green;
        }

        // ─────────────────────────────────────────
        // INVENTORY REPORT
        // ─────────────────────────────────────────
        private void LoadInventoryReport()
        {
            dgvInventory.Rows.Clear();
            dgvInventory.Columns.Clear();

            dgvInventory.Columns.Add("Name", "Medicine Name");
            dgvInventory.Columns.Add("Quantity", "Current Stock");
            dgvInventory.Columns.Add("Price", "Price (Rs.)");
            dgvInventory.Columns.Add("Expiry", "Expiry Date");
            dgvInventory.Columns.Add("Status", "Status");

            // MedicineRepository handles all SQL — no SQL here!
            List<Medicine> medicines = MedicineRepository.GetAllMedicines();

            foreach (Medicine m in medicines)
            {
                string status = m.Quantity == 0 ? "Out of Stock" :
                                m.Quantity < 10 ? "Low Stock" : "In Stock";

                int rowIndex = dgvInventory.Rows.Add(
                    m.Name,
                    m.Quantity,
                    $"Rs. {m.Price:F2}",
                    m.ExpiryDate,
                    status
                );

                // Color code rows by stock status
                if (m.Quantity == 0)
                    dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                else if (m.Quantity < 10)
                    dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        // ─────────────────────────────────────────
        // SEARCH BILLS
        // ─────────────────────────────────────────
        private void txtBillSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBillingReport(txtBillSearch.Text.Trim());
        }

        // ─────────────────────────────────────────
        // REFRESH BUTTONS
        // ─────────────────────────────────────────
        private void btnRefreshBills_Click(object sender, EventArgs e)
        {
            txtBillSearch.Clear();
            LoadBillingReport();
            MessageBox.Show("Report refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            LoadInventoryReport();
            MessageBox.Show("Inventory refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
