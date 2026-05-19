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
            try
            {
                dgvMedicines.Rows.Clear();
                dgvMedicines.Columns.Clear();

                // Add columns
                dgvMedicines.Columns.Add("Id", "ID");
                dgvMedicines.Columns.Add("Name", "Medicine Name");
                dgvMedicines.Columns.Add("Quantity", "Quantity");
                dgvMedicines.Columns.Add("Price", "Price (Rs.)");
                dgvMedicines.Columns.Add("Expiry", "Expiry Date");

                // Hide ID column
                dgvMedicines.Columns["Id"].Visible = false;

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Medicines WHERE Name LIKE @search";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvMedicines.Rows.Add(
                                    reader["Id"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Quantity"].ToString(),
                                    reader["Price"].ToString(),
                                    reader["ExpiryDate"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // ADD MEDICINE
        // ─────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Medicines (Name, Quantity, Price, ExpiryDate) 
                                   VALUES (@name, @qty, @price, @expiry)";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text.Trim()));
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@expiry", txtExpiry.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Medicine added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding medicine: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Medicines 
                                   SET Name=@name, Quantity=@qty, Price=@price, ExpiryDate=@expiry 
                                   WHERE Id=@id";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text.Trim()));
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@expiry", txtExpiry.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedMedicineId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Medicine updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating medicine: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM Medicines WHERE Id=@id";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedMedicineId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Medicine deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadMedicines();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting medicine: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
