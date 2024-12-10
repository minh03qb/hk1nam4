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

    public partial class FormSalesman : Form
    {
        private string CurrentUserID { get; set; }
        private DataAccess Da { get; set; }
        private Login form1 { set; get; }


        public FormSalesman()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.lblHistory.Hide();

            this.lblStockInfoHeading.Show();
            this.dgvStockList.Show();

            this.pnlNewPassword.Hide();
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;

        }        
        
        public FormSalesman(Login form, string name, string id) : this()
        {
            this.form1 = form;
            this.lblWelcome.Text += name.ToUpper();
            this.CurrentUserID = id;
        }
        //
        //PASSWORD//
        //

        private void btnPassChange_Click(object sender, EventArgs e) // Show new password panel
        {
            this.pnlNewPassword.Show();
            this.txtSearch.Text = "Search by Code";
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.lblHistory.Hide();
            this.lblStockInfoHeading.Hide();
            this.dgvStockList.Hide();
            this.dtpBillDate.Hide();

        }

        private void SetPassword() //setting new password
        {
            var sql = "select Password from UserInfo where UserID like '" + this.CurrentUserID + "';";
            var ds = this.Da.ExecuteQuery(sql);
            if (this.txtCurrentPassword.Text.Equals(ds.Tables[0].Rows[0][0].ToString()))
            {
                if (this.txtNewPassword.Text == this.txtConfirmPassword.Text)
                {
                    var input = "update Userinfo set Password = '" + this.txtConfirmPassword.Text + "' where UserID like '" + this.CurrentUserID + "'; ";
                    var ds2 = this.Da.ExecuteQuery(input);
                    MessageBox.Show("Password Changed");
                    this.pnlNewPassword.Hide();
                    //this.pnlAll.Show();
                }
                else
                {
                    MessageBox.Show("New password does not match!");

                }
            }
            else
            {
                MessageBox.Show("Current password does not match!");
            }
        }

        private void btnConfirmPass_Click_1(object sender, EventArgs e) //confirm password
        {
            SetPassword();
            this.txtCurrentPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmPassword.Clear();
        }

        private void btnCross_Click(object sender, EventArgs e)//close password panel
        {
            this.txtCurrentPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmPassword.Clear();
            this.pnlNewPassword.Hide();
        }
        //


        //
        // LOG-OUT //
        private void btnLogOut_Click(object sender, EventArgs e) // log out 
        {
            form1.Show();
            this.Hide();
        }

        //
        //STOCK//
        //
        private void ShowStock(string input = "select * from StockInfo;") //Initialise Stock Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.DataSource = ds.Tables[0];
            this.dgvStockList.Show();
        }

        private void btnShowStock_Click(object sender, EventArgs e) // show stock list
        {
            this.lblStockInfoHeading.Show();
            this.lblHistory.Hide();
            this.pnlNewPassword.Hide();
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = true;
            this.txtSearch.Text = "Search by Code";
            ShowStock();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) //search bar
        {
            this.dtpBillDate.Hide();
            var sql = "select * from StockInfo where Code like '" + this.txtSearch.Text + "%'or MedName like '" + this.txtSearch.Text + "%';";
            this.ShowStock(sql);
        }

        private void btnOrder_Click(object sender, EventArgs e) // order 
        {
            this.pnlNewPassword.Hide();
            FormOrder order = new FormOrder(this);
            order.Show();
        }

        private void txtSearch_Click(object sender, EventArgs e)// clear search bar upon click
        {
            this.txtSearch.Clear();
        }

        private void FormSalesman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewBilling_Click(object sender, EventArgs e)//view billing history
        {
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Show();
            this.dtpBillDate.Show();
            this.dgvStockList.Hide();
            this.pnlNewPassword.Hide();
            this.txtSearch.Enabled = false;
            this.txtSearch.Text = "Search by Code";
            ShowOrder();
        }

        private void ShowOrder(string input = "select * from OrderInfo;") //show order info
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.DataSource = ds.Tables[0];
            this.dgvOrderList.Show();
        }

        private void dtpBillDate_ValueChanged(object sender, EventArgs e)
        {
            var input = "select * from OrderInfo where Date like '" + dtpBillDate.Text + "';";
            ShowOrder(input);
        }



        //

        //
    }
}
