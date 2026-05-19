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
            dgvPatients.Rows.Clear();
            dgvPatients.Columns.Clear();

            dgvPatients.Columns.Add("Id", "ID");
            dgvPatients.Columns.Add("Name", "Patient Name");
            dgvPatients.Columns.Add("Age", "Age");
            dgvPatients.Columns.Add("Contact", "Contact");
            dgvPatients.Columns.Add("Disease", "Disease");

            dgvPatients.Columns["Id"].Visible = false;

            // All data comes from PatientRepository — no SQL here!
            List<Patient> patients = PatientRepository.GetAllPatients(search);

            foreach (Patient p in patients)
            {
                dgvPatients.Rows.Add(
                    p.Id,
                    p.Name,
                    p.Age,
                    p.Contact,
                    p.Disease
                );
            }
        }

        // ─────────────────────────────────────────
        // ADD PATIENT
        // ─────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Patient patient = new Patient
            {
                Name = txtName.Text.Trim(),
                Age = int.Parse(txtAge.Text.Trim()),
                Contact = txtContact.Text.Trim(),
                Disease = txtDisease.Text.Trim()
            };

            if (PatientRepository.AddPatient(patient))
            {
                MessageBox.Show("Patient added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadPatients();
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

            Patient patient = new Patient
            {
                Id = selectedPatientId,
                Name = txtName.Text.Trim(),
                Age = int.Parse(txtAge.Text.Trim()),
                Contact = txtContact.Text.Trim(),
                Disease = txtDisease.Text.Trim()
            };

            if (PatientRepository.UpdatePatient(patient))
            {
                MessageBox.Show("Patient updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadPatients();
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
                if (PatientRepository.DeletePatient(selectedPatientId))
                {
                    MessageBox.Show("Patient deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadPatients();
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
                MessageBox.Show("Please enter contact!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
