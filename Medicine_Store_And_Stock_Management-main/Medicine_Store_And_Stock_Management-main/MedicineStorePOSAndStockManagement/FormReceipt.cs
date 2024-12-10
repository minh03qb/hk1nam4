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
    public partial class FormReceipt : Form
    {
        private DataAccess Da { get; set; }
        private FormOrder form1 { set; get; }
        private FormSalesman form2 { set; get; }
        public FormReceipt()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            PrintReceipt();
            ShowCart();
            ShowOrderID();
            this.lblDate.Text += DateTime.Now.ToString("yyyy/MM/dd");
        }        
        
        public FormReceipt(FormOrder form, FormSalesman formS, string grandTotal): this()
        {
            this.form1 = form;
            this.form2 = formS;
            this.form1.Hide();
            this.lblGrandTotal.Text = grandTotal;
        }

        private void btnReturntoOrder_Click(object sender, EventArgs e) // return to FormOrder
        {
            form2.Show();
            this.Hide();
        }

        private void FormReceipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PrintReceipt() // initialise customer info
        {
            var sql = "select * from CustomerInfo order by CustomerID desc;";
            var ds = this.Da.ExecuteQuery(sql);
            this.lblCustomerName.Text += ds.Tables[0].Rows[0]["CustomerName"].ToString().ToUpper();
            this.lblCustomerID.Text = ds.Tables[0].Rows[0]["CustomerID"].ToString();
            this.lblContactNumber.Text += ds.Tables[0].Rows[0]["ContactNumber"].ToString();
            

        }

        private void ShowCart(string input = "select * from CartInfo;") //Initialise Cart Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = ds.Tables[0];
            this.dgvCart.Show();

            var sql = "delete from CartInfo;";
            var dsdel = this.Da.ExecuteQuery(sql);
        }        
        
        private void ShowOrderID() //Initialise OrderID
        {
            var input = "select OrderID from OrderInfo where CustomerID = '"+this.lblCustomerID.Text+"';";
            var ds = this.Da.ExecuteQuery(input);

            this.dgvCart.AutoGenerateColumns = false;
            this.lblOrderID.Text = ds.Tables[0].Rows[0]["OrderID"].ToString();
        }
    }
}
