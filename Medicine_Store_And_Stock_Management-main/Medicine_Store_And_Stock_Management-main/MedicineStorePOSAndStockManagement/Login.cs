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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {

            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where UserID = '" + this.txtUserId.Text + "' and Password='" + this.txtPassword.Text + "';";

            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Valid");

                this.ClearData();
                this.Hide();
                string userName = ds.Tables[0].Rows[0][1].ToString();
                string userId = ds.Tables[0].Rows[0][0].ToString();

                if (ds.Tables[0].Rows[0][3].ToString().ToLower() == "owner")
                {
                    FormOwner owner = new FormOwner(this, userName, userId);
                    owner.Show();
                }

                else if (ds.Tables[0].Rows[0][3].ToString().ToLower() == "manager")
                {
                    FormManager manager = new FormManager(this, userName, userId);
                    manager.Show();
                }

                else if (ds.Tables[0].Rows[0][3].ToString().ToLower() == "salesman")
                {
                    FormSalesman salesman = new FormSalesman(this, userName, userId);
                    salesman.Show();
                }
            }
            else
            {
                MessageBox.Show("User Id or Password Incorrect!");
            }
        }

        private void ClearData()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLoginText_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
