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
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(298, 57);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(251, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin!";
            // 
            // btnMedicines
            // 
            btnMedicines.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnMedicines.Location = new Point(81, 223);
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
            btnPateints.Location = new Point(81, 284);
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
            btnBilling.Location = new Point(448, 223);
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
            btnReports.Location = new Point(448, 289);
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
            btnLogout.Location = new Point(280, 355);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}