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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            lblTitle.BackColor = Color.FromArgb(27, 79, 114);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(929, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(27, 79, 114);
            lblName.Location = new Point(47, 169);
            lblName.Name = "lblName";
            lblName.Size = new Size(147, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Patient Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.FromArgb(27, 79, 114);
            lblAge.Location = new Point(58, 240);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(54, 28);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.FromArgb(27, 79, 114);
            lblContact.Location = new Point(58, 321);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(90, 28);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact:";
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisease.ForeColor = Color.FromArgb(27, 79, 114);
            lblDisease.Location = new Point(58, 381);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(89, 28);
            lblDisease.TabIndex = 4;
            lblDisease.Text = "Disease:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(27, 79, 114);
            lblSearch.Location = new Point(265, 107);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(348, 104);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 34);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(211, 179);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 34);
            txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(211, 240);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 34);
            txtAge.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(211, 318);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(150, 34);
            txtContact.TabIndex = 9;
            // 
            // txtDisease
            // 
            txtDisease.BorderStyle = BorderStyle.FixedSingle;
            txtDisease.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisease.Location = new Point(211, 381);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(150, 34);
            txtDisease.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(689, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 67);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Patient";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(689, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 59);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(689, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 58);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(689, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(167, 57);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(214, 234, 248);
            dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPatients.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(27, 79, 114);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.Location = new Point(2, 436);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
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
            BackColor = Color.FromArgb(235, 245, 251);
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