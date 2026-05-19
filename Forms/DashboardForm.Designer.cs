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
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(26, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(740, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Clinic Management System";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMedicines
            // 
            btnMedicines.BackColor = Color.FromArgb(41, 128, 185);
            btnMedicines.Cursor = Cursors.Hand;
            btnMedicines.FlatStyle = FlatStyle.Flat;
            btnMedicines.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnMedicines.ForeColor = Color.White;
            btnMedicines.Location = new Point(112, 234);
            btnMedicines.Name = "btnMedicines";
            btnMedicines.Size = new Size(200, 94);
            btnMedicines.TabIndex = 1;
            btnMedicines.Text = "Medicine Inventory";
            btnMedicines.UseVisualStyleBackColor = false;
            btnMedicines.Click += btnMedicines_Click;
            // 
            // btnPateints
            // 
            btnPateints.BackColor = Color.FromArgb(39, 174, 96);
            btnPateints.Cursor = Cursors.Hand;
            btnPateints.FlatStyle = FlatStyle.Flat;
            btnPateints.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPateints.ForeColor = Color.White;
            btnPateints.Location = new Point(439, 234);
            btnPateints.Name = "btnPateints";
            btnPateints.Size = new Size(200, 94);
            btnPateints.TabIndex = 2;
            btnPateints.Text = "Patient Management";
            btnPateints.UseVisualStyleBackColor = false;
            btnPateints.Click += btnPateints_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(142, 68, 173);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(44, 353);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(200, 94);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(243, 156, 18);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(294, 353);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 94);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(540, 353);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 94);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMedicineCount
            // 
            lblMedicineCount.AutoSize = true;
            lblMedicineCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicineCount.ForeColor = Color.White;
            lblMedicineCount.Location = new Point(77, 124);
            lblMedicineCount.Name = "lblMedicineCount";
            lblMedicineCount.Size = new Size(143, 30);
            lblMedicineCount.TabIndex = 6;
            lblMedicineCount.Text = "Medicines: 0";
            // 
            // lblPatientCount
            // 
            lblPatientCount.AutoSize = true;
            lblPatientCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientCount.ForeColor = Color.White;
            lblPatientCount.Location = new Point(258, 124);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(122, 30);
            lblPatientCount.TabIndex = 7;
            lblPatientCount.Text = "Patients: 0";
            // 
            // lblBillCount
            // 
            lblBillCount.AutoSize = true;
            lblBillCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillCount.ForeColor = Color.White;
            lblBillCount.Location = new Point(414, 124);
            lblBillCount.Name = "lblBillCount";
            lblBillCount.Size = new Size(148, 30);
            lblBillCount.TabIndex = 8;
            lblBillCount.Text = "Bills Today: 0";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.White;
            lblLowStock.Location = new Point(593, 124);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(143, 30);
            lblLowStock.TabIndex = 9;
            lblLowStock.Text = "Low Stock: 0";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 79, 114);
            ClientSize = new Size(778, 464);
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