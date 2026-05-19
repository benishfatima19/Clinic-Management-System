using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Database;

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
            try
            {
                dgvBills.Rows.Clear();
                dgvBills.Columns.Clear();

                dgvBills.Columns.Add("BillId", "Bill ID");
                dgvBills.Columns.Add("Patient", "Patient Name");
                dgvBills.Columns.Add("Date", "Date");
                dgvBills.Columns.Add("Total", "Total (Rs.)");

                decimal totalRevenue = 0;

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT b.Id, p.Name, b.Date, b.Total 
                                   FROM Bills b 
                                   JOIN Patients p ON b.PatientId = p.Id
                                   WHERE p.Name LIKE @search
                                   ORDER BY b.Date DESC";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal total = Convert.ToDecimal(reader["Total"]);
                                totalRevenue += total;

                                dgvBills.Rows.Add(
                                    reader["Id"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Date"].ToString(),
                                    $"Rs. {total:F2}"
                                );
                            }
                        }
                    }
                }

                lblTotalRevenue.Text = $"Total Revenue: Rs. {totalRevenue:F2}";
                lblTotalRevenue.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading billing report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // INVENTORY REPORT
        // ─────────────────────────────────────────
        private void LoadInventoryReport()
        {
            try
            {
                dgvInventory.Rows.Clear();
                dgvInventory.Columns.Clear();

                dgvInventory.Columns.Add("Name", "Medicine Name");
                dgvInventory.Columns.Add("Quantity", "Current Stock");
                dgvInventory.Columns.Add("Price", "Price (Rs.)");
                dgvInventory.Columns.Add("Expiry", "Expiry Date");
                dgvInventory.Columns.Add("Status", "Status");

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Medicines ORDER BY Quantity ASC";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int qty = Convert.ToInt32(reader["Quantity"]);
                            string status = qty == 0 ? "Out of Stock" :
                                           qty < 10 ? "Low Stock" : "In Stock";

                            int rowIndex = dgvInventory.Rows.Add(
                                reader["Name"].ToString(),
                                qty.ToString(),
                                $"Rs. {reader["Price"]}",
                                reader["ExpiryDate"].ToString(),
                                status
                            );

                            // Color code the rows
                            if (qty == 0)
                                dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                            else if (qty < 10)
                                dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                            else
                                dgvInventory.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Billing report refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            LoadInventoryReport();
            MessageBox.Show("Inventory report refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
