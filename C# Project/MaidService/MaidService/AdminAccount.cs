using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaidService
{
    public partial class AdminAccount : Form
    {
        Admin a1;
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }
        public AdminAccount(Admin a)
        {
            InitializeComponent();
            this.a1 = a;

            txtUsername.Enabled = false;
            txtName.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            string sql = "select * from [Admin] where Username='" + a1.Username + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from [Login] where Username='" + a1.Username + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            Role u = new Role(Ds1);
            Admin a = new Admin(Ds);
            txtUsername.Text = a.Username;
            txtName.Text = a.Name;
            txtPassword.Text = u.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(a1);
            this.Visible = false;
            ap.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // txtUsername.Enabled = true;
            txtName.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update Your Data", "Do you want to update your data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {

                    string sql = @"update [Admin] setName='" + this.txtName.Text + @"',
                        Password='" + this.txtPassword.Text + @"'
                        where Username='" + a1.Username + "';";

                    DataAccess.ExecuteQuery(sql);
                    string sqll = @"update [Login] set Password='" + this.txtPassword.Text + @"' where Username='" + a1.Username + "';";
                    DataAccess.ExecuteQuery(sqll);
                    MessageBox.Show("Data has been updated");
                }
                txtUsername.Enabled = false;
                txtName.Enabled = false;
                txtPassword.Enabled = false;

            }
            else { }
        }
    }
}
