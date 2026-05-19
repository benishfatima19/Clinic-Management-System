using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Clinic_System.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Database;

namespace Clinic_System.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardStats(); // Load stats on open
        }

        // ─────────────────────────────────────────
        // LOAD DASHBOARD STATISTICS
        // ─────────────────────────────────────────
        private void LoadDashboardStats()
        {
            try
            {
                // Show logged in user
                lblWelcome.Text = $"Welcome, {LoginForm.LoggedInUser}!";

                // Total medicines — from MedicineRepository
                var medicines = MedicineRepository.GetAllMedicines();
                lblMedicineCount.Text = $"💊 Medicines: {medicines.Count}";

                // Total patients — from PatientRepository
                var patients = PatientRepository.GetAllPatients();
                lblPatientCount.Text = $"👤 Patients: {patients.Count}";

                // Bills today — from BillRepository
                int todayBills = BillRepository.GetTodayBillsCount();
                lblBillCount.Text = $"🧾 Bills Today: {todayBills}";

                // Total revenue — from BillRepository
                decimal revenue = BillRepository.GetTotalRevenue();
                lblRevenue.Text = $"💰 Revenue: Rs. {revenue:F2}";

                // Low stock count — from MedicineRepository
                int lowStock = 0;
                foreach (var m in medicines)
                    if (m.Quantity < 10) lowStock++;

                lblLowStock.Text = $"⚠️ Low Stock: {lowStock}";
                lblLowStock.ForeColor = lowStock > 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.Show();
        }

        private void btnPateints_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        
    }
}
