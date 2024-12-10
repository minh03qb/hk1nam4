using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineStorePOSAndStockManagement
{
    public partial class FormOwner : Form
    {
        private string CurrentUserID { get; set; }
        private DataAccess Da { get; set; }
        private Login form1 { set; get; }

        public FormOwner()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Hide();

            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.dgvOrderList.Hide();
            this.pnlNewPassword.Hide();
            this.btnDelete.Enabled = false;
            this.btnUpdateStock.Enabled = false;
            this.btnUpdateUser.Enabled = false;
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;

        }
        public FormOwner(Login form, string name, string id) : this()
        {
            this.form1 = form;
            this.lblWelcome.Text += name.ToUpper();
            this.CurrentUserID = id;

        }

        private void ClearContent()
        {
            this.txtAddress.Clear();
            this.w.Clear();
            this.txtCompany.Clear();
            this.txtMedicineName.Clear();
            this.txtMedicinePrice.Clear();
            this.txtNewPassword.Clear();
            this.txtPhoneNumber.Clear();
            this.txtQuantity.Clear();
            this.txtSalary.Clear();
            this.txtUpdateAddress.Clear();
            this.txtUpdatePhone.Clear();
            this.txtUpdateSalary.Clear();
            this.txtUpdateStock.Clear();
            this.txtUserID.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.btnUpdateStock.Enabled = false;

        }
        private void ShowEmployee(string input = "select * from UserInfo;") //Initialise Employee Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvEmployeeList.AutoGenerateColumns = false;
            this.dgvEmployeeList.DataSource = ds.Tables[0];
            this.dgvEmployeeList.Show();
        }

        private void ShowStock(string input = "select * from StockInfo;") //Initialise Stock Table
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvStockList.AutoGenerateColumns = false;
            this.dgvStockList.DataSource = ds.Tables[0];
            this.dgvStockList.Show();
        }

        private bool IsValidToSaveUser() //Check if any field is empty or not for employee
        {
            if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtUserName.Text) ||
                String.IsNullOrEmpty(this.cmbRole.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrEmpty(this.txtAddress.Text) ||
                String.IsNullOrEmpty(this.txtPhoneNumber.Text))
            {
                return false;
            }
            else
                return true;
        }
        private bool IsValidToSaveStock() //Check if any field is empty or not for stock
        {
            if (String.IsNullOrEmpty(this.w.Text) || String.IsNullOrEmpty(this.txtMedicineName.Text) ||
                String.IsNullOrEmpty(this.dtpManufacture.Text) || String.IsNullOrEmpty(this.txtMedicinePrice.Text) ||
                String.IsNullOrEmpty(this.dtpExpire.Text) || String.IsNullOrEmpty(this.txtCompany.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) //click add employee button to view panel
        {
            this.AutoGenerateCustomerID();
            this.txtSearch.Text = "Search by ID or Code";
            this.pnlAddEmployee.Show();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();
            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.lblHistory.Hide();
            this.pnlNewPassword.Hide();
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            btnDelete.Enabled = false;
            this.btnUpdateStock.Enabled = false;
            this.btnUpdateUser.Enabled = false;
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;

        }

        private void FormOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnShowEmployee_Click(object sender, EventArgs e)// show employee button
        {
            btnDelete.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.btnUpdateUser.Enabled = false;
            this.lblEmployeeInfoHeading.Show();
            this.dgvEmployeeList.Show();
            this.pnlNewPassword.Hide();
            this.lblStockInfoHeading.Hide();
            this.dgvStockList.Hide();
            this.lblHistory.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
            ShowEmployee();

            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.dgvOrderList.Hide();
        }

        private void btnShowStock_Click(object sender, EventArgs e) //show stock button
        {
            btnDelete.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.btnUpdateUser.Enabled = false;
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Show();
            this.pnlNewPassword.Hide();
            this.dgvStockList.Show();
            this.dgvEmployeeList.Hide();
            this.lblHistory.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
            ShowStock();

            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.dgvOrderList.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e) //logout
        {
            form1.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) //search bar
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

        private void rbEmployee_CheckedChanged(object sender, EventArgs e) //selecting radiobutton of employee
        {
            this.pnlUpdateUser.Hide();
            this.pnlUpdateStock.Hide();
            this.btnDelete.Enabled = true;
            this.txtSearch.Enabled = true;
            this.dgvStockList.Hide();
            this.dgvEmployeeList.Show();
            this.lblEmployeeInfoHeading.Show();
            this.lblStockInfoHeading.Hide();
            this.txtSearch.Text = "Search by ID or Code";
            this.dtpBillDate.Hide();
            this.lblHistory.Hide();
            ShowEmployee();
        }

        private void rbStock_CheckedChanged(object sender, EventArgs e) //selecting radiobutton of stock
        {
            this.btnDelete.Enabled = true;
            this.txtSearch.Enabled = true;
            this.pnlAddMedicine.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Show();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Show();
            this.pnlAddEmployee.Hide();
            this.txtSearch.Text = "Search by ID or Code";
            this.dtpBillDate.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlUpdateStock.Hide();
            this.lblHistory.Hide();
            ShowStock();
        }

        private void btnConfirm_Click(object sender, EventArgs e) // insert button for employee
        {
            try //Handle exception for sql query
            {
                if (!this.IsValidToSaveUser())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                else if (!DigitCheck(txtSalary.Text) || !DigitCheck(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Invalid operation. Salary or Phone Number is not Numeric.");
                    return;
                }


                //insert
                var sql = @"insert into UserInfo values('" + this.txtUserID.Text + "','" + this.txtPassword.Text + "','" + this.txtUserName.Text + "','" + this.cmbRole.Text + "','" + this.txtSalary.Text + "','" + this.txtPhoneNumber.Text + "','" + this.txtAddress.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion successful");
                else
                    MessageBox.Show("Data insertion failed");

                string input = "select * from UserInfo;";
                ShowEmployee(input);
                ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnUpdateMedPrice_Click(object sender, EventArgs e) // clicking update medicine
        {
            btnDelete.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.btnUpdateUser.Enabled = false;
            this.AutoGenerateMedID();
            this.pnlAddMedicine.Show();
            this.lblStockInfoHeading.Show();
            this.lblEmployeeInfoHeading.Hide();
            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlNewPassword.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlDelete.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.lblHistory.Hide();
            this.lblStockInfoHeading.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
        }

        private void btnConfirmStock_Click(object sender, EventArgs e) //confirm stock button to insert
        {
            try //Handle exception for sql query
            {
                if (!this.IsValidToSaveStock())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                else if (!DigitCheck(txtMedicinePrice.Text) || !DigitCheck(txtQuantity.Text))
                {
                    MessageBox.Show("Invalid operation. Price or Quantity is not Numeric.");
                    return;
                }

                //insert
                var sql = @"insert into StockInfo values('" + this.w.Text + "','" + this.txtMedicineName.Text + "','" + this.txtMedicinePrice.Text + "','" + this.dtpManufacture.Text + "','" + this.dtpExpire.Text + "','" + this.txtCompany.Text + "','" + this.txtQuantity.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion successful");
                else
                    MessageBox.Show("Data insertion failed");

                string input = "select * from StockInfo;";
                ShowStock(input);
                ClearContent();
                this.txtSearch.Text = "Search by ID or Code";
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e) //delete button
        {
            try
            {
                if (rbEmployee.Checked)
                {
                    btnDelete.Enabled = true;
                    var id = this.dgvEmployeeList.CurrentRow.Cells[0].Value.ToString();
                    var name = this.dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();



                    var sql = "delete from UserInfo where UserID = '" + id + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);



                    if (count == 1)
                        MessageBox.Show(name + " has been deleted successfully");
                    else
                        MessageBox.Show("Data deletion failed");

                    ShowEmployee();
                    ClearContent();

                }
                else if (rbStock.Checked)
                {
                    btnDelete.Enabled = true;
                    var id = this.dgvStockList.CurrentRow.Cells[0].Value.ToString();
                    var name = this.dgvStockList.CurrentRow.Cells[1].Value.ToString();



                    var sql = "delete from StockInfo where Code = '" + id + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);



                    if (count == 1)
                        MessageBox.Show(name + " has been deleted successfully");
                    else
                        MessageBox.Show("Data deletion failed");

                    ShowStock();
                    ClearContent();
                }

                else
                {
                    MessageBox.Show("No item or category has been selected.");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e) //remove employee button
        {
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.pnlDelete.Show();
            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.lblHistory.Hide();
            this.pnlNewPassword.Hide();
            this.lblStockInfoHeading.Hide();
            btnDelete.Enabled = false;
            this.btnUpdateUser.Enabled = false;
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
            ClearContent();
        }


        private void btnUpdateStock_Click(object sender, EventArgs e) //update stock button
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
                ClearContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e) // update user button
        {
            try
            {
                if (!DigitCheck(txtUpdateSalary.Text) || !DigitCheck(txtUpdatePhone.Text))
                {
                    MessageBox.Show("Invalid operation. Salary or Phone number is not Numeric.");
                    return;
                }
                var id = this.dgvEmployeeList.CurrentRow.Cells["UserID"].Value.ToString();
                var name = this.dgvEmployeeList.CurrentRow.Cells["UserName"].Value.ToString();
                var sql = @"Update UserInfo set Role ='" + this.cmbUpdateRole.Text + @"', Salary ='" + this.txtUpdateSalary.Text + @"', PhoneNumber ='" + this.txtUpdatePhone.Text + @"', Address ='" + this.txtUpdateAddress.Text + @"'where UserID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been updated successfully");
                else
                    MessageBox.Show("User update failed");

                ShowEmployee();
                ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btInfoUpdate_Click(object sender, EventArgs e) // update info of employee or stock
        {

            if (rbEmployee.Checked)
            {
                this.pnlUpdateUser.Show();
                this.pnlAddEmployee.Hide();
                this.pnlAddMedicine.Hide();
                this.pnlDelete.Hide();
                this.pnlUpdateStock.Hide();
            }
            else if (rbStock.Checked)
            {
                this.pnlUpdateStock.Show();
                this.pnlAddEmployee.Hide();
                this.pnlAddMedicine.Hide();
                this.pnlDelete.Hide();
                this.pnlUpdateUser.Hide();
            }
        }

        private void btnViewBilling_Click(object sender, EventArgs e) // select billing history
        {
            btnDelete.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.rbStock.Checked = false;
            this.rbEmployee.Checked = false;
            this.btnUpdateUser.Enabled = false;
            this.lblHistory.Show();
            this.pnlNewPassword.Hide();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();

            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.pnlUpdateStock.Hide();
            this.pnlUpdateUser.Hide();
            this.dtpBillDate.Show();
            this.txtSearch.Enabled = false;
            ClearContent();
            ShowOrder();
        }

        private void ShowOrder(string input = "select * from OrderInfo;") //show order info
        {
            var ds = this.Da.ExecuteQuery(input);

            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.DataSource = ds.Tables[0];
            this.dgvOrderList.Show();
            ClearContent();
        }

        private void btnUpdateEmployeeInfo_Click(object sender, EventArgs e) // select update employee button
        {
            this.rbStock.Checked = false;
            btnDelete.Enabled = false;
            this.rbEmployee.Checked = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.lblEmployeeInfoHeading.Show();
            this.pnlUpdateUser.Show();
            this.dgvEmployeeList.Show();
            this.pnlNewPassword.Hide();
            this.pnlUpdateStock.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.lblHistory.Hide();
            this.lblStockInfoHeading.Hide();
            this.btnUpdateUser.Enabled = false;
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
            ShowEmployee();
            ClearContent();

        }

        private void btnUpdateStockMed_Click(object sender, EventArgs e) //select update stock button
        {
            this.rbStock.Checked = false;
            btnDelete.Enabled = false;
            this.txtSearch.Text = "Search by ID or Code";
            this.rbEmployee.Checked = false;
            this.lblStockInfoHeading.Show();
            this.pnlUpdateStock.Show();
            this.dgvStockList.Show();
            this.pnlUpdateUser.Hide();
            this.pnlNewPassword.Hide();
            this.pnlAddEmployee.Hide();
            this.pnlAddMedicine.Hide();
            this.pnlDelete.Hide();
            this.dgvEmployeeList.Hide();
            this.dgvOrderList.Hide();
            this.lblHistory.Hide();
            this.lblEmployeeInfoHeading.Hide();
            this.btnUpdateUser.Enabled = false;
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;
            ShowStock();
            ClearContent();

        }

        private void AutoGenerateCustomerID() //for autogenerating customer id
        {
            var sql = "select UserID from UserInfo order by UserID desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["UserID"].ToString();
            string[] temp = previousId.Split('-');
            int number = Convert.ToInt32(temp[1]);
            string newUserID = "E-" + (++number).ToString("d4");
            this.txtUserID.Text = newUserID;
        }

        private void AutoGenerateMedID() //for autogenerating medicine id
        {
            var sql = "select Code from StockInfo order by Code desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            string previousId = ds.Tables[0].Rows[0]["Code"].ToString();
            int number = Convert.ToInt32(previousId);
            string newCode = (++number).ToString();
            this.w.Text = newCode;
        }

        private void dgvStockList_Click(object sender, EventArgs e) // to store currently selected quantity from stocklist
        {
            this.txtUpdateStock.Text = this.dgvStockList.CurrentRow.Cells["Quantity"].Value.ToString();
            this.btnUpdateStock.Enabled = true;
            this.txtSearch.Text = "Search by ID or Code";
        }

        private void dgvEmployeeList_Click(object sender, EventArgs e) //to store currently selected employee info from employee list
        {
            this.cmbUpdateRole.Text = this.dgvEmployeeList.CurrentRow.Cells["Role"].Value.ToString();//this.cmbUpdateRole.Text;
            this.txtUpdateSalary.Text = this.dgvEmployeeList.CurrentRow.Cells["Salary"].Value.ToString();// this.txtUpdateSalary.Text;
            this.txtUpdatePhone.Text = this.dgvEmployeeList.CurrentRow.Cells["PhoneNumber"].Value.ToString(); //this.txtUpdatePhone.Text;
            this.txtUpdateAddress.Text = this.dgvEmployeeList.CurrentRow.Cells["Address"].Value.ToString(); //this.txtUpdateAddress.Text;
            this.btnUpdateUser.Enabled = true;
        }

        private void txtSearch_Click(object sender, EventArgs e) //clear search bar upon click
        {
            this.txtSearch.Clear();
        }

        //PASSWORD SET//
        //
        private void btnPassChange_Click(object sender, EventArgs e)
        {
            this.txtSearch.Text = "Search by ID or Code";
            this.pnlNewPassword.Show();
            this.dgvEmployeeList.Hide();
            this.dgvStockList.Hide();
            this.dgvOrderList.Hide();
            this.lblEmployeeInfoHeading.Hide();
            this.lblStockInfoHeading.Hide();
            this.lblHistory.Hide();
            this.dtpBillDate.Hide();
            this.txtSearch.Enabled = false;

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

        private bool ValidateNewPass()
        {
            if (String.IsNullOrEmpty(txtCurrentPassword.Text) || String.IsNullOrEmpty(txtNewPassword.Text) || String.IsNullOrEmpty(txtConfirmPassword.Text))
                return false;
            else
                return true;
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (ValidateNewPass())
            {
                SetPassword();
                this.txtCurrentPassword.Clear();
                this.txtNewPassword.Clear();
                this.txtConfirmPassword.Clear();
            }

            else
            {
                MessageBox.Show("You need to provide all the information");
            }

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

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pnlNewPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }
        //
    }
}
