namespace Clinic_System.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnMedicines = new Button();
            btnPateints = new Button();
            btnBilling = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            lblMedicineCount = new Label();
            lblPatientCount = new Label();
            lblBillCount = new Label();
            lblLowStock = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(258, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(251, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin!";
            // 
            // btnMedicines
            // 
            btnMedicines.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnMedicines.Location = new Point(112, 234);
            btnMedicines.Name = "btnMedicines";
            btnMedicines.Size = new Size(238, 60);
            btnMedicines.TabIndex = 1;
            btnMedicines.Text = "Medicine Inventory";
            btnMedicines.UseVisualStyleBackColor = true;
            btnMedicines.Click += btnMedicines_Click;
            // 
            // btnPateints
            // 
            btnPateints.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPateints.Location = new Point(439, 234);
            btnPateints.Name = "btnPateints";
            btnPateints.Size = new Size(238, 60);
            btnPateints.TabIndex = 2;
            btnPateints.Text = "Patient Management";
            btnPateints.UseVisualStyleBackColor = true;
            btnPateints.Click += btnPateints_Click;
            // 
            // btnBilling
            // 
            btnBilling.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBilling.Location = new Point(44, 353);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(223, 60);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReports.Location = new Point(294, 353);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(223, 60);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogout.Location = new Point(540, 353);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(223, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMedicineCount
            // 
            lblMedicineCount.AutoSize = true;
            lblMedicineCount.Location = new Point(77, 124);
            lblMedicineCount.Name = "lblMedicineCount";
            lblMedicineCount.Size = new Size(110, 25);
            lblMedicineCount.TabIndex = 6;
            lblMedicineCount.Text = "Medicines: 0";
            // 
            // lblPatientCount
            // 
            lblPatientCount.AutoSize = true;
            lblPatientCount.Location = new Point(258, 124);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(92, 25);
            lblPatientCount.TabIndex = 7;
            lblPatientCount.Text = "Patients: 0";
            // 
            // lblBillCount
            // 
            lblBillCount.AutoSize = true;
            lblBillCount.Location = new Point(414, 124);
            lblBillCount.Name = "lblBillCount";
            lblBillCount.Size = new Size(113, 25);
            lblBillCount.TabIndex = 8;
            lblBillCount.Text = "Bills Today: 0";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(593, 124);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(111, 25);
            lblLowStock.TabIndex = 9;
            lblLowStock.Text = "Low Stock: 0";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLowStock);
            Controls.Add(lblBillCount);
            Controls.Add(lblPatientCount);
            Controls.Add(lblMedicineCount);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnBilling);
            Controls.Add(btnPateints);
            Controls.Add(btnMedicines);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Management System - Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnMedicines;
        private Button btnPateints;
        private Button btnBilling;
        private Button btnReports;
        private Button btnLogout;
        private Label lblMedicineCount;
        private Label lblPatientCount;
        private Label lblBillCount;
        private Label lblLowStock;
    }
}