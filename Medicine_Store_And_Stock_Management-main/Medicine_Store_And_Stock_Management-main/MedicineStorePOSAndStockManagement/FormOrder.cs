using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineStorePOSAndStockManagement
{
    public partial class FormOrder : Form
    {
        private int Grandtotal { get; set; }
        private string CurrentProductName { get; set; }
        private string CurrentProductCode { get; set; }
        private string CurrentProductPrice { get; set; }
        private string CurrentProductQuantity { get; set; }
        private string CartProductName { get; set; }
        private string CartProductQuantity { get; set; }
        private string CartProductPrice { get; set; }
        private string CartProductCode { get; set; }
        private DataAccess Da { get; set; }
        private FormSalesman form1 { set; get; }

        public FormOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.ShowStock();

            AutoIdGenerate();       // CUSTOMER ID
            AutoOrderIdGenerate(); // ORDER ID 
            this.lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");  // date show
            this.btnAddtoCart.Enabled = false;
            this.btnRemove.Enabled = false;
        }

        public FormOrder(FormSalesman form) : this()
        {
            this.form1 = form;
        }

        private void ShowStock(string input = "select * from StockInfo;") //Initialise Stock Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.DataSource = ds.Tables[0];
            this.dgvStockList.Show();
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            var sql = "delete from CartInfo;";
            var ds = this.Da.ExecuteQuery(sql);
            form1.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) // search bar
        {
            var sql = "select * from StockInfo where Code like '" + this.txtSearch.Text + "%'or MedName like '" + this.txtSearch.Text + "%';";
            this.ShowStock(sql);
        }

        private void btnAddtoCart_Click(object sender, EventArgs e) //add to cart list
        {
            try //Handle exception for sql query
            {
                if (!this.IsValidQuantity())
                {
                    MessageBox.Show("Quantity not entered!");
                    return;
                }

                else if (!DigitCheck(this.txtAddQuantity.Text))
                {
                    MessageBox.Show("Invalid operation. Quantity is not Numeric.");
                    return;
                }

                var input = "update StockInfo set Quantity = '" + (Convert.ToInt32(this.CurrentProductQuantity) - Convert.ToInt32(txtAddQuantity.Text)) + "' where Code ='" + this.CurrentProductCode + "';";
                var ds = this.Da.ExecuteQuery(input);

                ShowStock();

                //insert
                var sql = @"insert into CartInfo values('" + this.CurrentProductName + "','" + this.txtAddQuantity.Text + "','" + CalculatePrice(txtAddQuantity.Text, this.CurrentProductPrice) + "','" + this.lblOrderID.Text + "','" + this.CurrentProductCode + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                this.lblGrandTotal.Text = this.Grandtotal.ToString();

                this.txtAddQuantity.Clear();

                ShowCart();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private bool IsValidQuantity() //Check if quantity is empty to add to cart
        {
            if (String.IsNullOrEmpty(this.txtAddQuantity.Text))
            {
                return false;
            }
            else
                return true;
        }

        private int CalculatePrice(string quantity, string price) // for adding the product price with grand total
        {
            int total = Convert.ToInt32(quantity) * Convert.ToInt32(price);
            this.Grandtotal += total;
            return total;
        }


        private void ShowCart(string input = "select * from CartInfo;") //Initialise Cart Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = ds.Tables[0];
            this.dgvCart.Show();
        }

        private void dgvCart_Click(object sender, EventArgs e) // to store product details from cart
        {
            this.btnAddtoCart.Enabled = false;
            this.btnRemove.Enabled = true;
            this.CartProductName = this.dgvCart.CurrentRow.Cells["CartMedName"].Value.ToString();
            this.CartProductQuantity = this.dgvCart.CurrentRow.Cells["MedQuantity"].Value.ToString();
            this.CartProductPrice = this.dgvCart.CurrentRow.Cells["MedPrice"].Value.ToString();
            this.CartProductCode = this.dgvCart.CurrentRow.Cells["MedCode"].Value.ToString();
        }

        private Boolean IsValidCustomer() // to check whether customer id and name is provided
        {
            if (String.IsNullOrEmpty(this.txtCustomerID.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e) // confirm order
        {

            try //Handle exception for sql query
            {
                if (!this.IsValidCustomer())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                else if (!DigitCheck(this.txtCustomerNumber.Text))
                {
                    MessageBox.Show("Invalid operation. Customer Number is not Numeric.");
                    return;
                }



                //insert
                var sql = @"insert into CustomerInfo values('" + this.txtCustomerID.Text + "','" + this.txtCustomerName.Text + "','" + this.txtCustomerNumber.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                var sq = @"insert into OrderInfo values('" + this.lblOrderID.Text + "','" + this.txtCustomerID.Text + "','" + this.lblGrandTotal.Text + "','" + this.lblDate.Text + "');";
                int ds = this.Da.ExecuteDMLQuery(sq);


                FormReceipt receipt = new FormReceipt(this, form1, this.lblGrandTotal.Text);
                receipt.Show();

                AutoOrderIdGenerate(); // ORDER ID 

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void dgvStockList_Click(object sender, EventArgs e) // to store current selected product details from stocklist
        {
            this.btnAddtoCart.Enabled = true;
            this.btnRemove.Enabled = false;
            this.CurrentProductName = this.dgvStockList.CurrentRow.Cells["MedName"].Value.ToString();
            this.CurrentProductPrice = this.dgvStockList.CurrentRow.Cells["Price"].Value.ToString();
            this.CurrentProductQuantity = this.dgvStockList.CurrentRow.Cells["Quantity"].Value.ToString();
            this.CurrentProductCode = this.dgvStockList.CurrentRow.Cells["Code"].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e) //remove from cart
        {
            try //Handle exception for sql query
            {

                var input = "update StockInfo set Quantity += '" + Convert.ToInt32(this.CartProductQuantity) + "' where Code ='" + this.CartProductCode + "';";
                int ds = this.Da.ExecuteDMLQuery(input);

                ShowStock();

                //delete
                this.Grandtotal -= Convert.ToInt32(this.CartProductPrice);
                var sql = "delete from CartInfo where MedicineName = '" + this.CartProductName + "' and Quantity = '" + this.CartProductQuantity + "' and Price = '" + this.CartProductPrice + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                this.lblGrandTotal.Text = this.Grandtotal.ToString();

                ShowCart();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)//clear search bar upon click
        {
            this.txtSearch.Clear();
        }

        private void AutoIdGenerate() // for autogenerating customer id
        {
            var sql = "select CustomerID from CustomerInfo order by CustomerID desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["CustomerID"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newCustomerID = "C-" + (++number).ToString("d3");
            this.txtCustomerID.Text = newCustomerID;
        }

        private void AutoOrderIdGenerate() // for autogenerating order id
        {
            var sql = "select OrderID from OrderInfo order by OrderID desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["OrderID"].ToString();
            int number = Convert.ToInt32(previousId);
            string newOrderID = (++number).ToString("d4");
            this.lblOrderID.Text = newOrderID;

        }

        private bool DigitCheck(string number)
        {
            int i = 0;
            while (i < number.Length)
            {
                if (char.IsLetter(number[i]))
                    return false;
                i++;
            }
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
