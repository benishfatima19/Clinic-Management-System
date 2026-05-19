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
    public partial class PatientForm : Form
    {
        private int selectedPatientId = -1;

        public PatientForm()
        {
            InitializeComponent();
            LoadPatients();
        }
        // ─────────────────────────────────────────
        // LOAD ALL PATIENTS INTO DATAGRIDVIEW
        // ─────────────────────────────────────────
        private void LoadPatients(string search = "")
        {
            try
            {
                dgvPatients.Rows.Clear();
                dgvPatients.Columns.Clear();

                dgvPatients.Columns.Add("Id", "ID");
                dgvPatients.Columns.Add("Name", "Patient Name");
                dgvPatients.Columns.Add("Age", "Age");
                dgvPatients.Columns.Add("Contact", "Contact");
                dgvPatients.Columns.Add("Disease", "Disease");

                dgvPatients.Columns["Id"].Visible = false;

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Patients WHERE Name LIKE @search";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvPatients.Rows.Add(
                                    reader["Id"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Age"].ToString(),
                                    reader["Contact"].ToString(),
                                    reader["Disease"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // ADD PATIENT
        // ─────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Patients (Name, Age, Contact, Disease) 
                                   VALUES (@name, @age, @contact, @disease)";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text.Trim()));
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@disease", txtDisease.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Patient added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ─────────────────────────────────────────
        // UPDATE PATIENT
        // ─────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == -1)
            {
                MessageBox.Show("Please select a patient to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Patients 
                                   SET Name=@name, Age=@age, Contact=@contact, Disease=@disease 
                                   WHERE Id=@id";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text.Trim()));
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@disease", txtDisease.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedPatientId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Patient updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ─────────────────────────────────────────
        // DELETE PATIENT
        // ─────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == -1)
            {
                MessageBox.Show("Please select a patient to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this patient?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // First check if patient has any bills
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        string checkSql = "SELECT COUNT(*) FROM Bills WHERE PatientId=@id";
                        using (SqliteCommand cmd = new SqliteCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedPatientId);
                            int billCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (billCount > 0)
                            {
                                MessageBox.Show(
                                    $"Cannot delete this patient!\nThis patient has {billCount} bill(s) on record.\nOnly patients with no billing history can be deleted.",
                                    "Cannot Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        // Safe to delete — no bills found
                        string deleteSql = "DELETE FROM Patients WHERE Id=@id";
                        using (SqliteCommand cmd = new SqliteCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedPatientId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Patient deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadPatients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting patient: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─────────────────────────────────────────
        // SEARCH PATIENT
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPatients(txtSearch.Text.Trim());
        }
        // ─────────────────────────────────────────
        // CLICK ROW → FILL FIELDS
        // ─────────────────────────────────────────
        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];
                selectedPatientId = int.Parse(row.Cells["Id"].Value.ToString());
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtDisease.Text = row.Cells["Disease"].Value.ToString();
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
            txtAge.Clear();
            txtContact.Clear();
            txtDisease.Clear();
            selectedPatientId = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter patient name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                MessageBox.Show("Please enter age!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                MessageBox.Show("Please enter contact number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
