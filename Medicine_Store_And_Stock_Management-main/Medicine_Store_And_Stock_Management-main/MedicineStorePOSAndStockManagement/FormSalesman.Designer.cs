
namespace MedicineStorePOSAndStockManagement
{
    partial class FormSalesman
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
            panel1 = new System.Windows.Forms.Panel();
            btnLogOut = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btnPassChange = new System.Windows.Forms.Button();
            btnShowStock = new System.Windows.Forms.Button();
            btnViewBilling = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnlAll = new System.Windows.Forms.Panel();
            dtpBillDate = new System.Windows.Forms.DateTimePicker();
            pnlNewPassword = new System.Windows.Forms.Panel();
            btnCross = new System.Windows.Forms.Button();
            btnConfirmPass = new System.Windows.Forms.Button();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtCurrentPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblHistory = new System.Windows.Forms.Label();
            lblStockInfoHeading = new System.Windows.Forms.Label();
            dgvStockList = new System.Windows.Forms.DataGridView();
            Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ManufactureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel5 = new System.Windows.Forms.Panel();
            btnOrder = new System.Windows.Forms.Button();
            pnlSearch = new System.Windows.Forms.Panel();
            lblSearchBar = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlAll.SuspendLayout();
            pnlNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockList).BeginInit();
            panel5.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(224, 206, 170);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1425, 191);
            panel1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogOut.Location = new System.Drawing.Point(57, 152);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new System.Drawing.Size(111, 33);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPassChange);
            panel3.Controls.Add(btnShowStock);
            panel3.Controls.Add(btnViewBilling);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(235, 11);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1178, 147);
            panel3.TabIndex = 3;
            // 
            // btnPassChange
            // 
            btnPassChange.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPassChange.Location = new System.Drawing.Point(1008, 3);
            btnPassChange.Name = "btnPassChange";
            btnPassChange.Size = new System.Drawing.Size(167, 34);
            btnPassChange.TabIndex = 8;
            btnPassChange.Text = "Change Password";
            btnPassChange.UseVisualStyleBackColor = true;
            btnPassChange.Click += btnPassChange_Click;
            // 
            // btnShowStock
            // 
            btnShowStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShowStock.Location = new System.Drawing.Point(368, 61);
            btnShowStock.Name = "btnShowStock";
            btnShowStock.Size = new System.Drawing.Size(179, 75);
            btnShowStock.TabIndex = 7;
            btnShowStock.Text = "Show Stock";
            btnShowStock.UseVisualStyleBackColor = true;
            btnShowStock.Click += btnShowStock_Click;
            // 
            // btnViewBilling
            // 
            btnViewBilling.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnViewBilling.Location = new System.Drawing.Point(631, 61);
            btnViewBilling.Name = "btnViewBilling";
            btnViewBilling.Size = new System.Drawing.Size(179, 75);
            btnViewBilling.TabIndex = 6;
            btnViewBilling.Text = "View Billing History";
            btnViewBilling.UseVisualStyleBackColor = true;
            btnViewBilling.Click += btnViewBilling_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(507, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(178, 20);
            label2.TabIndex = 2;
            label2.Text = "Choose an operation";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(224, 206, 170);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new System.Drawing.Point(11, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(219, 160);
            panel2.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWelcome.Location = new System.Drawing.Point(33, 129);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(135, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Back ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.salesmanlogo;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(46, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(111, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlAll
            // 
            pnlAll.BackColor = System.Drawing.Color.FromArgb(231, 224, 208);
            pnlAll.Controls.Add(dtpBillDate);
            pnlAll.Controls.Add(pnlNewPassword);
            pnlAll.Controls.Add(dgvOrderList);
            pnlAll.Controls.Add(lblHistory);
            pnlAll.Controls.Add(lblStockInfoHeading);
            pnlAll.Controls.Add(dgvStockList);
            pnlAll.Controls.Add(panel5);
            pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlAll.Location = new System.Drawing.Point(0, 191);
            pnlAll.Name = "pnlAll";
            pnlAll.Size = new System.Drawing.Size(1425, 507);
            pnlAll.TabIndex = 3;
            // 
            // dtpBillDate
            // 
            dtpBillDate.CustomFormat = "yyyy-MM-dd";
            dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpBillDate.Location = new System.Drawing.Point(446, 8);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new System.Drawing.Size(121, 27);
            dtpBillDate.TabIndex = 12;
            dtpBillDate.ValueChanged += dtpBillDate_ValueChanged;
            // 
            // pnlNewPassword
            // 
            pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(119, 97, 83);
            pnlNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlNewPassword.Controls.Add(btnCross);
            pnlNewPassword.Controls.Add(btnConfirmPass);
            pnlNewPassword.Controls.Add(txtConfirmPassword);
            pnlNewPassword.Controls.Add(label5);
            pnlNewPassword.Controls.Add(txtNewPassword);
            pnlNewPassword.Controls.Add(label4);
            pnlNewPassword.Controls.Add(txtCurrentPassword);
            pnlNewPassword.Controls.Add(label3);
            pnlNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pnlNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            pnlNewPassword.Location = new System.Drawing.Point(68, 109);
            pnlNewPassword.Name = "pnlNewPassword";
            pnlNewPassword.Size = new System.Drawing.Size(452, 275);
            pnlNewPassword.TabIndex = 7;
            // 
            // btnCross
            // 
            btnCross.BackColor = System.Drawing.Color.Firebrick;
            btnCross.Location = new System.Drawing.Point(415, 3);
            btnCross.Name = "btnCross";
            btnCross.Size = new System.Drawing.Size(28, 29);
            btnCross.TabIndex = 17;
            btnCross.Text = "X";
            btnCross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCross.UseVisualStyleBackColor = false;
            btnCross.Click += btnCross_Click;
            // 
            // btnConfirmPass
            // 
            btnConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnConfirmPass.Location = new System.Drawing.Point(171, 206);
            btnConfirmPass.Name = "btnConfirmPass";
            btnConfirmPass.Size = new System.Drawing.Size(113, 37);
            btnConfirmPass.TabIndex = 16;
            btnConfirmPass.Text = "Confirm";
            btnConfirmPass.UseVisualStyleBackColor = true;
            btnConfirmPass.Click += btnConfirmPass_Click_1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfirmPassword.Location = new System.Drawing.Point(203, 151);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(176, 27);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(34, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(156, 23);
            label5.TabIndex = 13;
            label5.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNewPassword.Location = new System.Drawing.Point(203, 110);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new System.Drawing.Size(176, 27);
            txtNewPassword.TabIndex = 12;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(34, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(126, 23);
            label4.TabIndex = 11;
            label4.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCurrentPassword.Location = new System.Drawing.Point(203, 68);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new System.Drawing.Size(176, 27);
            txtCurrentPassword.TabIndex = 10;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(34, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 23);
            label3.TabIndex = 9;
            label3.Text = "Current Password";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.AllowUserToDeleteRows = false;
            dgvOrderList.BackgroundColor = System.Drawing.Color.FromArgb(169, 160, 142);
            dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderID, CustomerID, TotalPrice, Date });
            dgvOrderList.Location = new System.Drawing.Point(0, 34);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new System.Drawing.Size(570, 539);
            dgvOrderList.TabIndex = 11;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "Order ID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Grand Total";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Transaction Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHistory.Location = new System.Drawing.Point(3, 6);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new System.Drawing.Size(176, 28);
            lblHistory.TabIndex = 10;
            lblHistory.Text = "BILLING HISTORY";
            // 
            // lblStockInfoHeading
            // 
            lblStockInfoHeading.AutoSize = true;
            lblStockInfoHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStockInfoHeading.Location = new System.Drawing.Point(11, 6);
            lblStockInfoHeading.Name = "lblStockInfoHeading";
            lblStockInfoHeading.Size = new System.Drawing.Size(189, 28);
            lblStockInfoHeading.TabIndex = 6;
            lblStockInfoHeading.Text = "Stock Information ";
            // 
            // dgvStockList
            // 
            dgvStockList.AllowUserToAddRows = false;
            dgvStockList.AllowUserToDeleteRows = false;
            dgvStockList.BackgroundColor = System.Drawing.Color.FromArgb(169, 160, 142);
            dgvStockList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Code, MedName, Price, ManufactureDate, ExpiryDate, Company, Quantity });
            dgvStockList.Location = new System.Drawing.Point(0, 34);
            dgvStockList.Name = "dgvStockList";
            dgvStockList.ReadOnly = true;
            dgvStockList.RowHeadersWidth = 51;
            dgvStockList.RowTemplate.Height = 29;
            dgvStockList.Size = new System.Drawing.Size(575, 492);
            dgvStockList.TabIndex = 4;
            // 
            // Code
            // 
            Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Code.DataPropertyName = "Code";
            Code.HeaderText = "Code";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.ReadOnly = true;
            // 
            // MedName
            // 
            MedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            MedName.DataPropertyName = "MedName";
            MedName.HeaderText = "Name";
            MedName.MinimumWidth = 6;
            MedName.Name = "MedName";
            MedName.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // ManufactureDate
            // 
            ManufactureDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ManufactureDate.DataPropertyName = "ManufactureDate";
            ManufactureDate.HeaderText = "Manufactured Date";
            ManufactureDate.MinimumWidth = 6;
            ManufactureDate.Name = "ManufactureDate";
            ManufactureDate.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.HeaderText = "Expiry Date";
            ExpiryDate.MinimumWidth = 6;
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.ReadOnly = true;
            // 
            // Company
            // 
            Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Company.DataPropertyName = "Company";
            Company.HeaderText = "Company";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnOrder);
            panel5.Controls.Add(pnlSearch);
            panel5.Location = new System.Drawing.Point(573, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(852, 527);
            panel5.TabIndex = 3;
            // 
            // btnOrder
            // 
            btnOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOrder.Location = new System.Drawing.Point(293, 304);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(284, 80);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblSearchBar);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new System.Drawing.Point(8, 6);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(832, 170);
            pnlSearch.TabIndex = 3;
            // 
            // lblSearchBar
            // 
            lblSearchBar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblSearchBar.Location = new System.Drawing.Point(268, 10);
            lblSearchBar.Name = "lblSearchBar";
            lblSearchBar.Size = new System.Drawing.Size(159, 28);
            lblSearchBar.TabIndex = 7;
            lblSearchBar.Text = "Search Bar";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(169, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(363, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search by Code";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(553, 93);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(141, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Medicine";
            // 
            // FormSalesman
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1425, 698);
            Controls.Add(pnlAll);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "FormSalesman";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormSalesman";
            FormClosed += FormSalesman_FormClosed;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlAll.ResumeLayout(false);
            pnlAll.PerformLayout();
            pnlNewPassword.ResumeLayout(false);
            pnlNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockList).EndInit();
            panel5.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.Button btnViewBilling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.Button btnConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockInfoHeading;
        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufactureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
    }
}