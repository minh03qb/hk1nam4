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
    public partial class FormManager : Form
    {
        private  string CurrentUserID { get; set; }
        private DataAccess Da { get; set; }
        private Login form1 { set; get; }
        public FormManager()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Hide();

            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();

            this.pnlNewPassword.Hide();
            this.pnlUpdateStock.Hide();
            this.dtpBillDate.Hide();
            this.btnUpdateStock.Enabled = false;
            this.txtSearch.Enabled = false;
        }

        public FormManager(Login form, string name, string id) : this()
        {
            this.form1 = form;
            this.lblWelcome.Text += name.ToUpper();
            this.CurrentUserID = id;
        }

        //
        // LOG-OUT //
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        //

        //
        // SEARCH //
        private void txtSearch_TextChanged(object sender, EventArgs e)//search bar
        {
            if (rbEmployee.Checked)
            {
                var sql = "select * from UserInfo where UserID like '" + this.txtSearch.Text + "%'or UserName like '" + this.txtSearch.Text + "%';";
                this.ShowEmployee(sql);
            }
            else if (rbStock.Checked)
            {
                var sql = "select * from StockInfo where Code like '" + this.txtSearch.Text + "%'or MedName like '" + this.txtSearch.Text + "%';";
                this.ShowStock(sql);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)//click to clear search bar
        {
            this.txtSearch.Clear();
        }
        //

        private void btnViewBilling_Click(object sender, EventArgs e) //view billing list
        {
            this.txtSearch.Text = "Search by ID or Code";
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.lblHistory.Show();
            this.pnlNewPassword.Hide();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.pnlUpdateStock.Hide();
            this.dtpBillDate.Show();
            this.txtSearch.Enabled = false;
            ShowOrder();
        }

        private void ShowOrder(string input = "select * from OrderInfo;") //show order info
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.DataSource = ds.Tables[0];
            this.dgvOrderList.Show();
        }

        //
        // EMPLOYEE //

        private void ShowEmployee(string input = "select * from UserInfo;") //Initialise Employee Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvEmployeeList.AutoGenerateColumns = false;
            this.dgvEmployeeList.DataSource = ds.Tables[0];
            this.dgvEmployeeList.Show();
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)//view employee list
        {
            this.lblEmployeeInfoHeading.Show();
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Hide();
            this.dgvStockList.Hide();
            this.pnlNewPassword.Hide();
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.txtSearch.Enabled = true;
            this.txtSearch.Text = "Search by ID or Code";
            ShowEmployee();
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)//select employee radiobutton
        {
            this.txtSearch.Text = "Search by ID or Code";
            this.txtSearch.Enabled = true;
            this.dgvStockList.Hide();
            this.dgvEmployeeList.Show();
            this.lblEmployeeInfoHeading.Show();
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Hide();
            this.dtpBillDate.Hide();
            this.dgvOrderList.Hide();
            ShowEmployee();
        }

        //

        //
        // STOCK //

        private void ShowStock(string input = "select * from StockInfo;") //show Stock Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.DataSource = ds.Tables[0];
            this.dgvStockList.Show();
        }


        private void btnShowStock_Click(object sender, EventArgs e)//view stocklist
        {
            this.lblEmployeeInfoHeading.Hide();
            this.lblHistory.Hide();
            this.lblStockInfoHeading.Show();
            this.dgvEmployeeList.Hide();
            this.pnlNewPassword.Hide();
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.rbStock.Checked = false;
            this.txtSearch.Enabled = true;
            this.rbEmployee.Checked = false;
            this.txtSearch.Text = "Search by ID or Code";
 
            ShowStock();
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e)//select stock radiobutton
        {
            this.txtSearch.Text = "Search by ID or Code";
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Show();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Show();
            this.lblHistory.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = true;
            ShowStock();
        }

        private void btnUpdateMedPrice_Click(object sender, EventArgs e)//button to show update panel for stock
        {
            this.dgvStockList.Show();
            this.ShowStock();
            this.lblHistory.Hide();
            this.pnlUpdateStock.Show();
            this.pnlNewPassword.Hide();
            this.dgvOrderList.Hide();
            this.dtpBillDate.Hide();
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.txtSearch.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)//button to update stock
        {
            try
            {
                if (!DigitCheck(txtUpdateStock.Text))
                {
                    MessageBox.Show("Invalid operation. Quantity is not Numeric.");
                    return;
                }


                var id = this.dgvStockList.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvStockList.CurrentRow.Cells[1].Value.ToString();



                var sql = "update StockInfo set Quantity = " + this.txtUpdateStock.Text + "where Code = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " stock has been updated");
                else
                    MessageBox.Show("Stock Update failed");

                ShowStock();
                this.txtUpdateStock.Clear();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvStockList_Click(object sender, EventArgs e)//to store current selected item from stock
        {
            this.txtUpdateStock.Text = this.dgvStockList.CurrentRow.Cells["Quantity"].Value.ToString();
        }

        //

        private void FormManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //

        //PASSWORD SET//
        //
        private void btnPassChange_Click(object sender, EventArgs e)
        {
            
            this.pnlNewPassword.Show();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.txtSearch.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.dtpBillDate.Hide();
            this.lblHistory.Hide();
        }

        private void SetPassword()
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

        private void btnConfirmPass_Click(object sender, EventArgs e)
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

        private void txtUpdateStock_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdateStock.Enabled = true;
            this.txtSearch.Text = "Search by ID or Code";
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

        private void dtpBillDate_ValueChanged(object sender, EventArgs e)
        {
            var input = "select * from OrderInfo where Date like '" + dtpBillDate.Text + "';";
            ShowOrder(input);
        }

        //

    }
}
