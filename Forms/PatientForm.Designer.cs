namespace Clinic_System.Forms
{
    partial class PatientForm
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
            lblTitle = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblContact = new Label();
            lblDisease = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtDisease = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvPatients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(287, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Management";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblName.Location = new Point(47, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Patient Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAge.Location = new Point(58, 240);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(53, 28);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblContact.Location = new Point(58, 321);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(86, 28);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact:";
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDisease.Location = new Point(58, 381);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(86, 28);
            lblDisease.TabIndex = 4;
            lblDisease.Text = "Disease:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(265, 107);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(77, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(348, 104);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(211, 179);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(211, 240);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(211, 318);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(150, 31);
            txtContact.TabIndex = 9;
            // 
            // txtDisease
            // 
            txtDisease.Location = new Point(211, 381);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(150, 31);
            txtDisease.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(710, 214);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Patient";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(710, 254);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(710, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(710, 334);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(2, 436);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 62;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(926, 225);
            dgvPatients.TabIndex = 15;
            dgvPatients.CellClick += dgvPatients_CellClick;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 664);
            Controls.Add(dgvPatients);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDisease);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblDisease);
            Controls.Add(lblContact);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblAge;
        private Label lblContact;
        private Label lblDisease;
        private Label lblSearch;
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtDisease;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvPatients;
    }
}