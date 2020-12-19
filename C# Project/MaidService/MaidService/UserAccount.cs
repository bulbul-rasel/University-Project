using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaidService
{
    public partial class UserAccount : Form
    {
        User u1;
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }
        public UserAccount(User u1)
        {
            InitializeComponent();
            this.u1 = u1;
            txtUsername.Enabled = false;
            txtName.Enabled = false;
            txtNid.Enabled = false;
            txtEmail.Enabled = false;
            txtGender.Enabled = false;
            txtPhone.Enabled = false;
            txtPassword.Enabled = false;
            richTxtAddress.Enabled = false;
            comboQuestion.Enabled = false;
            txtAnswer.Enabled = false;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            string sql = "select * from [User] where Username='" + u1.Username + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from [Login] where Username='" + u1.Username + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            Role r = new Role(Ds1);
            User u = new User(Ds);
            txtUsername.Text = u.Username;
            txtName.Text = u.Name;
            
            txtNid.Text=u.Nid;
            txtEmail.Text =u.Email;
            txtGender.Text = u.Gender;
            txtPhone.Text = u.Phone;
            txtPassword.Text = r.Password;
            richTxtAddress.Text = u.Address;
            comboQuestion.Text = u.Question;
            txtAnswer.Text= u.Answer;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile up = new UserProfile(u1);
            this.Visible = false;
            up.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtUsername.Enabled = true;
            txtName.Enabled = true;
            txtNid.Enabled = true;
            txtEmail.Enabled = true;
            txtGender.Enabled = true;
            txtPhone.Enabled = true;
            txtPassword.Enabled = true;
            richTxtAddress.Enabled = true;
            comboQuestion.Enabled = true;
            txtAnswer.Enabled = true;
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

                    string sql = @"update [User] set Name='" + this.txtName.Text + @"',
                        Nid='" + this.txtNid.Text + @"',
                        Email='" + this.txtEmail.Text + @"',
                        Gender='" + this.txtGender.Text + @"',
                        Phone='" + this.txtPhone.Text + @"',
                        Password='" + this.txtPassword.Text + @"',
                        Address='" + this.richTxtAddress.Text + @"',
                        Question='" + this.comboQuestion.Text + @"',
                        Answer='" + this.txtAnswer.Text + @"'
                        where Username='" + u1.Username + "';";

                    DataAccess.ExecuteQuery(sql);
                    string sqll = @"update [Login] set Password='" + this.txtPassword.Text + @"' where Username='" + u1.Username + "';";
                    DataAccess.ExecuteQuery(sqll);
                    MessageBox.Show("Data has been updated");
                }
                txtUsername.Enabled = false;
                txtName.Enabled = false;
                txtNid.Enabled = false;
                txtEmail.Enabled = false;
                txtGender.Enabled = false;
                txtPhone.Enabled = false;
                txtPassword.Enabled = false;
                richTxtAddress.Enabled = false;
                comboQuestion.Enabled = false;
                txtAnswer.Enabled = false;

            }
            else { }
        }
    }
}
