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
    public partial class ForgotPassword : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Ds1 { get; set; }
        public ForgotPassword()
        {
            InitializeComponent();
            textUsername.Enabled = true;
            textAnswer.Enabled = true;
            textPassword.Enabled = false;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboStatus.Text == "User")
            {
                string sql = "select * from [User] where Username='" + this.textUsername.Text + "'";
                Ds = DataAccess.GetDataSet(sql);
                User u = new User(Ds);

                if (u.Answer==textAnswer.Text)
                {
                    string sql1 = "select * from [Login] where Username='" + this.textUsername.Text+ "'";
                    this.Ds = DataAccess.GetDataSet(sql1);
                    Role r = new Role(Ds);
                    textPassword.Text = r.Password;
                }
                else
                {
                    MessageBox.Show("Answer doesn't match!");
                }
                
            }
            else if (comboStatus.Text == "Maid")
            {
                string sql = "select * from [Maid] where Username='" + this.textUsername.Text + "'";
                Ds = DataAccess.GetDataSet(sql);
                Maid m = new Maid(Ds);

                if (m.Answer==textAnswer.Text)
                {
                    string sql1 = "select * from [Login] where Username='" + this.textUsername.Text+ "'";
                    this.Ds = DataAccess.GetDataSet(sql1);
                    Role r = new Role(Ds);
                    textPassword.Text = r.Password;
                }
                else
                {
                    MessageBox.Show("Answer doesn't match!");
                }

            }
            else
            {
                MessageBox.Show("error!!!", "Message");
            }   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
