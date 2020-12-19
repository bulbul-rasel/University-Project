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
    public partial class MaidAccount : Form
    {
        Maid m1;
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }
        public MaidAccount(Maid m1)
        {
            InitializeComponent();
            this.m1 = m1;
            txtUsername.Enabled = false;
            txtName.Enabled = false;
            txtNid.Enabled = false;
            txtEmail.Enabled = false;
            txtGender.Enabled = false;
            txtPhone.Enabled = false;
            txtPassword.Enabled = false;
            txtWorkType.Enabled = false;
            txtHours.Enabled = false;
            txtSalary.Enabled = false;
            richTxtAddress.Enabled = false;
            comboQuestion.Enabled = false;
            txtAnswer.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaidProfile mp = new MaidProfile(m1);
            this.Visible = false;
            mp.Visible = true;
        }

        private void MaidAccount_Load(object sender, EventArgs e)
        {
            string sql = "select * from [Maid] where Username='" + m1.Username + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from [Login] where Username='" + m1.Username + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            Role r = new Role(Ds1);
            Maid m2 = new Maid(Ds);
            txtUsername.Text = m2.Username;
            txtName.Text = m2.Name;

            txtNid.Text = m2.Nid;
            txtEmail.Text = m2.Email;
            txtGender.Text = m2.Gender;
            txtPhone.Text = m2.Phone;
            txtPassword.Text = r.Password;
            txtWorkType.Text = m2.WorkType;
            txtHours.Text = m1.WorkingHours;
            txtSalary.Text = m1.Salary;
            richTxtAddress.Text = m2.Address;
            comboQuestion.Text = m2.Question;
            txtAnswer.Text = m2.Answer;
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
            txtWorkType.Enabled = true;
            txtHours.Enabled = true;
            txtSalary.Enabled = true;
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

                    string sql = @"update [Maid] set Name='" + this.txtName.Text + @"',
                        Nid='" + this.txtNid.Text + @"',
                        Email='" + this.txtEmail.Text + @"',
                        Gender='" + this.txtGender.Text + @"',
                        Phone='" + this.txtPhone.Text + @"',
                        Password='" + this.txtPassword.Text + @"',
                        Work_Type='" + this.txtWorkType.Text + @"',
                        Working_Hours='" + this.txtHours.Text + @"',
                        Salary='" + this.txtSalary.Text + @"',
                        Address='" + this.richTxtAddress.Text + @"',
                        Question='" + this.comboQuestion.Text + @"',
                        Answer='" + this.txtAnswer.Text + @"'
                        where Username='" + m1.Username + "';";

                    DataAccess.ExecuteQuery(sql);
                    string sqll = @"update [Login] set Password='" + this.txtPassword.Text + @"' where Username='" + m1.Username + "';";
                    DataAccess.ExecuteQuery(sqll);
                    MessageBox.Show("Data has been updated");
                }
                //txtUsername.Enabled = false;
                txtName.Enabled = false;
                txtNid.Enabled = false;
                txtEmail.Enabled = false;
                txtGender.Enabled = false;
                txtPhone.Enabled = false;
                txtPassword.Enabled = false;
                txtWorkType.Enabled = false;
                txtHours.Enabled = false;
                txtSalary.Enabled = false;
                richTxtAddress.Enabled = false;
                comboQuestion.Enabled = false;
                txtAnswer.Enabled = false;

            }
            else { }
        }
    }
}
