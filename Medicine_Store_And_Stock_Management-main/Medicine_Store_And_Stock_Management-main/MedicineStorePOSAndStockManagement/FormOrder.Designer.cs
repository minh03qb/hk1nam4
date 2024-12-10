
namespace MedicineStorePOSAndStockManagement
{
    partial class FormOrder
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
            panel3 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblOrderID = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            btnRemove = new System.Windows.Forms.Button();
            btnConfirmOrder = new System.Windows.Forms.Button();
            dgvCart = new System.Windows.Forms.DataGridView();
            MedCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CartMedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblContactNumber = new System.Windows.Forms.Label();
            txtCustomerNumber = new System.Windows.Forms.TextBox();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtCustomerID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtAddQuantity = new System.Windows.Forms.TextBox();
            btnAddtoCart = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dgvStockList = new System.Windows.Forms.DataGridView();
            Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ManufactureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(894, 770);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.OldLace;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblOrderID);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblGrandTotal);
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnConfirmOrder);
            panel3.Controls.Add(dgvCart);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(480, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(414, 770);
            panel3.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(2, 7);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 20);
            label10.TabIndex = 31;
            label10.Text = "Date : ";
            // 
            // lblDate
            // 
            lblDate.Location = new System.Drawing.Point(48, 7);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(82, 20);
            lblDate.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(2, 27);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(83, 20);
            label9.TabIndex = 27;
            label9.Text = "OrderID  # ";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new System.Drawing.Point(78, 27);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new System.Drawing.Size(0, 20);
            lblOrderID.TabIndex = 18;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(183, 560);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(116, 22);
            label8.TabIndex = 26;
            label8.Text = "GrandTotal :                ";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGrandTotal.Location = new System.Drawing.Point(305, 560);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(85, 23);
            lblGrandTotal.TabIndex = 25;
            lblGrandTotal.Text = "               ";
            // 
            // btnRemove
            // 
            btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemove.Location = new System.Drawing.Point(8, 556);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(170, 29);
            btnRemove.TabIndex = 24;
            btnRemove.Text = "Remove from Cart";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmOrder.Location = new System.Drawing.Point(124, 640);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new System.Drawing.Size(174, 95);
            btnConfirmOrder.TabIndex = 23;
            btnConfirmOrder.Text = "Confirm and Proceed to Receipt";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { MedCode, CartMedName, MedQuantity, MedPrice });
            dgvCart.Location = new System.Drawing.Point(9, 53);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new System.Drawing.Size(395, 497);
            dgvCart.TabIndex = 21;
            dgvCart.Click += dgvCart_Click;
            // 
            // MedCode
            // 
            MedCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            MedCode.DataPropertyName = "Code";
            MedCode.HeaderText = "Code";
            MedCode.MinimumWidth = 6;
            MedCode.Name = "MedCode";
            MedCode.ReadOnly = true;
            // 
            // CartMedName
            // 
            CartMedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CartMedName.DataPropertyName = "MedicineName";
            CartMedName.HeaderText = "Name";
            CartMedName.MinimumWidth = 6;
            CartMedName.Name = "CartMedName";
            CartMedName.ReadOnly = true;
            // 
            // MedQuantity
            // 
            MedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            MedQuantity.DataPropertyName = "Quantity";
            MedQuantity.HeaderText = "Quantity";
            MedQuantity.MinimumWidth = 6;
            MedQuantity.Name = "MedQuantity";
            MedQuantity.ReadOnly = true;
            // 
            // MedPrice
            // 
            MedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            MedPrice.DataPropertyName = "Price";
            MedPrice.HeaderText = "Price";
            MedPrice.MinimumWidth = 6;
            MedPrice.Name = "MedPrice";
            MedPrice.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(157, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 41);
            label2.TabIndex = 7;
            label2.Text = "CART";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Moccasin;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblContactNumber);
            panel2.Controls.Add(txtCustomerNumber);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(txtCustomerID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAddQuantity);
            panel2.Controls.Add(btnAddtoCart);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvStockList);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(483, 770);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(259, 264);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(176, 23);
            label7.TabIndex = 17;
            label7.Text = "#Click to Select Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(3, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(235, 23);
            label6.TabIndex = 16;
            label6.Text = "Enter Customer Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 23);
            label5.TabIndex = 15;
            label5.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(3, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 23);
            label4.TabIndex = 14;
            label4.Text = "Customer ID";
            label4.Click += label4_Click;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContactNumber.Location = new System.Drawing.Point(3, 115);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new System.Drawing.Size(143, 23);
            lblContactNumber.TabIndex = 13;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.Location = new System.Drawing.Point(148, 113);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.Size = new System.Drawing.Size(147, 27);
            txtCustomerNumber.TabIndex = 12;
            txtCustomerNumber.TextChanged += txtCustomerNumber_TextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(148, 75);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(147, 27);
            txtCustomerName.TabIndex = 11;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(148, 42);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new System.Drawing.Size(147, 27);
            txtCustomerID.TabIndex = 10;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(139, 205);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 23);
            label3.TabIndex = 9;
            label3.Text = "Enter Quantity";
            // 
            // txtAddQuantity
            // 
            txtAddQuantity.Location = new System.Drawing.Point(272, 205);
            txtAddQuantity.Name = "txtAddQuantity";
            txtAddQuantity.Size = new System.Drawing.Size(42, 27);
            txtAddQuantity.TabIndex = 8;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddtoCart.Location = new System.Drawing.Point(329, 205);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new System.Drawing.Size(99, 28);
            btnAddtoCart.TabIndex = 7;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = true;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(3, 152);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(348, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "Search by Code";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(365, 153);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(63, 23);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(139, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 38);
            label1.TabIndex = 6;
            label1.Text = "STOCK";
            // 
            // dgvStockList
            // 
            dgvStockList.AllowUserToAddRows = false;
            dgvStockList.AllowUserToDeleteRows = false;
            dgvStockList.BackgroundColor = System.Drawing.Color.RosyBrown;
            dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Code, MedName, Price, ManufactureDate, ExpiryDate, Company, Quantity });
            dgvStockList.Location = new System.Drawing.Point(-35, 290);
            dgvStockList.Name = "dgvStockList";
            dgvStockList.ReadOnly = true;
            dgvStockList.RowHeadersWidth = 51;
            dgvStockList.RowTemplate.Height = 29;
            dgvStockList.Size = new System.Drawing.Size(518, 482);
            dgvStockList.TabIndex = 5;
            dgvStockList.Click += dgvStockList_Click;
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
            // FormOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 770);
            Controls.Add(panel1);
            Name = "FormOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormOrder";
            FormClosed += FormOrder_FormClosed;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufactureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddQuantity;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedPrice;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDate;
    }
}