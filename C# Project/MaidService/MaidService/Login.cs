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
    public partial class Home : Form
    {
        private DataSet Ds { get; set; }
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Userid or Passwor Missing.");
            }
            else 
            {
                try
                {
                    string sql = "select * from Login where Username = '" + this.txtUsername.Text + "' AND Password = '" + this.txtPassword.Text + "' ;";
                    Ds = DataAccess.GetDataSet(sql);

                    Role u = new Role(Ds);

                    if (u.Status=="Admin")
                    {
                        sql = "select * from [Admin] where Username = '" + this.txtUsername.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);
                        Admin ad = new Admin(Ds);

                        AdminProfile a = new AdminProfile(ad);
                        this.Visible = false;
                        a.Visible = true;

                    }
                    
                    else if (u.Status.Equals("User"))
                    {
                        sql = "select * from [User] where Username = '" + this.txtUsername.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);
                        User a = new User(Ds);

                        UserProfile u1 = new UserProfile(a);
                        this.Visible = false;
                        u1.Visible = true;
                    }
                    else if (u.Status.Equals("Maid"))
                    {
                        sql = "select * from [Maid] where Username = '" + this.txtUsername.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);
                        Maid m = new Maid(Ds);

                        MaidProfile mp = new MaidProfile(m);
                        this.Visible = false;
                        mp.Visible = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username and Password doesn't match!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option f2 = new Option();
            this.Visible = false;
            f2.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

          private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                checkShow.Text = "Hide Password";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                checkShow.Text = "Show Password";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            this.Visible = false;
            h.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
