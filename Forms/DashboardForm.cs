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
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Total medicines
                    string medSql = "SELECT COUNT(*) FROM Medicines";
                    using (SqliteCommand cmd = new SqliteCommand(medSql, conn))
                        lblMedicineCount.Text = "💊 Medicines: " + cmd.ExecuteScalar().ToString();

                    // Total patients
                    string patSql = "SELECT COUNT(*) FROM Patients";
                    using (SqliteCommand cmd = new SqliteCommand(patSql, conn))
                        lblPatientCount.Text = "👤 Patients: " + cmd.ExecuteScalar().ToString();

                    // Bills generated today
                    string billSql = "SELECT COUNT(*) FROM Bills WHERE Date=@date";
                    using (SqliteCommand cmd = new SqliteCommand(billSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        lblBillCount.Text = "🧾 Bills Today: " + cmd.ExecuteScalar().ToString();
                    }

                    // Low stock medicines (quantity < 10)
                    string lowSql = "SELECT COUNT(*) FROM Medicines WHERE Quantity < 10";
                    using (SqliteCommand cmd = new SqliteCommand(lowSql, conn))
                    {
                        int lowCount = Convert.ToInt32(cmd.ExecuteScalar());
                        lblLowStock.Text = "⚠️ Low Stock: " + lowCount;
                        // Make it red if there are low stock items
                        lblLowStock.ForeColor = lowCount > 0 ?
                            System.Drawing.Color.Red :
                            System.Drawing.Color.Green;
                    }
                }
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
