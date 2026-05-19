namespace Clinic_System.Forms
{
    partial class ReportsForm
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
            tabControl1 = new TabControl();
            tabBilling = new TabPage();
            dgvBills = new DataGridView();
            lblTotalRevenue = new Label();
            btnRefreshBills = new Button();
            txtBillSearch = new TextBox();
            lblBillSearch = new Label();
            tabInventory = new TabPage();
            btnRefreshInventory = new Button();
            dgvInventory = new DataGridView();
            lblLowStock = new Label();
            tabControl1.SuspendLayout();
            tabBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(377, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(73, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBilling);
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Location = new Point(0, 141);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(879, 452);
            tabControl1.TabIndex = 1;
            // 
            // tabBilling
            // 
            tabBilling.Controls.Add(dgvBills);
            tabBilling.Controls.Add(lblTotalRevenue);
            tabBilling.Controls.Add(btnRefreshBills);
            tabBilling.Controls.Add(txtBillSearch);
            tabBilling.Controls.Add(lblBillSearch);
            tabBilling.Location = new Point(4, 34);
            tabBilling.Name = "tabBilling";
            tabBilling.Padding = new Padding(3);
            tabBilling.Size = new Size(871, 414);
            tabBilling.TabIndex = 0;
            tabBilling.Text = "Billing Report";
            tabBilling.UseVisualStyleBackColor = true;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(13, 136);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersWidth = 62;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(862, 246);
            dgvBills.TabIndex = 4;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(674, 385);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(191, 25);
            lblTotalRevenue.TabIndex = 3;
            lblTotalRevenue.Text = "Total Revenue: Rs. 0.00";
            // 
            // btnRefreshBills
            // 
            btnRefreshBills.Location = new Point(681, 17);
            btnRefreshBills.Name = "btnRefreshBills";
            btnRefreshBills.Size = new Size(112, 34);
            btnRefreshBills.TabIndex = 2;
            btnRefreshBills.Text = "Refresh";
            btnRefreshBills.UseVisualStyleBackColor = true;
            btnRefreshBills.Click += btnRefreshBills_Click;
            // 
            // txtBillSearch
            // 
            txtBillSearch.Location = new Point(318, 17);
            txtBillSearch.Name = "txtBillSearch";
            txtBillSearch.Size = new Size(259, 31);
            txtBillSearch.TabIndex = 1;
            txtBillSearch.TextChanged += txtBillSearch_TextChanged;
            // 
            // lblBillSearch
            // 
            lblBillSearch.AutoSize = true;
            lblBillSearch.Location = new Point(130, 17);
            lblBillSearch.Name = "lblBillSearch";
            lblBillSearch.Size = new Size(151, 25);
            lblBillSearch.TabIndex = 0;
            lblBillSearch.Text = "Search by Patient:";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(btnRefreshInventory);
            tabInventory.Controls.Add(dgvInventory);
            tabInventory.Controls.Add(lblLowStock);
            tabInventory.Location = new Point(4, 34);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(871, 414);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory Report";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnRefreshInventory
            // 
            btnRefreshInventory.Location = new Point(732, 26);
            btnRefreshInventory.Name = "btnRefreshInventory";
            btnRefreshInventory.Size = new Size(112, 34);
            btnRefreshInventory.TabIndex = 2;
            btnRefreshInventory.Text = "Refresh";
            btnRefreshInventory.UseVisualStyleBackColor = true;
            btnRefreshInventory.Click += btnRefreshInventory_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(6, 117);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(859, 291);
            dgvInventory.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(22, 26);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(261, 25);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "⚠️ Low Stock Items (Qty < 10):";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 594);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            tabControl1.ResumeLayout(false);
            tabBilling.ResumeLayout(false);
            tabBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tabBilling;
        private TabPage tabInventory;
        private TextBox txtBillSearch;
        private Label lblBillSearch;
        private DataGridView dgvBills;
        private Label lblTotalRevenue;
        private Button btnRefreshBills;
        private Button btnRefreshInventory;
        private DataGridView dgvInventory;
        private Label lblLowStock;
    }
}