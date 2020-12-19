using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MaidService
{
    public partial class MaidRegistration : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Ds1 { get; set; }
        public MaidRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Visible = false;
            o.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string gender = "";
            if (radioBtnMale.Checked)
                gender = radioBtnMale.Text;
            if ((radioBtnFemale.Checked))
                gender = radioBtnFemale.Text;
            if (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtUsername.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtNid.Text) || string.IsNullOrEmpty(this.txtEmail.Text) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(this.txtPhone.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || this.comboWorkType.Text == "Work Type" || this.comboHours.Text == "Working Hours"|| string.IsNullOrEmpty(this.txtSalary.Text) || string.IsNullOrEmpty(this.richTxtAddress.Text) || this.comboQuestion.Text == "Question" || string.IsNullOrEmpty(this.txtAnswer.Text))
            {
                MessageBox.Show(this, "Please fill up all fields");
            }
            else
            {
                //Validation
                Regex uname;
                uname = new Regex(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
                Regex nid;
                nid = new Regex(@"^[0-9]{12}$");
                Regex emailch;
                emailch = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                Regex pass;
                pass = new Regex(@"^([a-zA-Z0-9]{6,15})$");
                if (!uname.IsMatch(txtUsername.Text))
                {
                    MessageBox.Show("Username format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (!nid.IsMatch(txtNid.Text))
                {
                    MessageBox.Show("Nid format is not correct and minimum length is 12.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNid.Focus();
                }
                else if (!emailch.IsMatch(txtEmail.Text))
                {

                    MessageBox.Show("E-mail address format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (!pass.IsMatch(txtPassword.Text))
                {
                    MessageBox.Show("Password format is not correct and minimum required length is 6.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {

                    //phone number check
                    Regex re = new Regex("^[0-9]{11}$");
                    bool isValid = re.IsMatch(txtPhone.Text);
                    if ((!isValid))
                    {
                        MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "select Username from [Login] where Username='" + this.txtUsername.Text + "';";
                        string sqll = "select Username from [Maid] where Username='" + this.txtUsername.Text + "';";
                        this.Ds = DataAccess.GetDataSet(sql);
                        this.Ds1 = DataAccess.GetDataSet(sqll);
                        if (this.Ds.Tables[0].Rows.Count == 1 || this.Ds1.Tables[0].Rows.Count == 1)
                        {
                            MessageBox.Show(this, "Your given username already exist!");
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=MaidDB;Integrated Security=true");
                            conn.Open();
                            string query = "";
                            query = "INSERT INTO [Maid] (Username,Name,Nid,Email,Gender,Phone,Password,Work_Type,Working_Hours,Salary,Address,Question,Answer) VALUES('" + txtUsername.Text + "','" + txtName.Text + "','" + txtNid.Text + "','" + txtEmail.Text + "','" + gender + "','" + txtPhone.Text + "','" + txtPassword.Text + "','" + comboWorkType.Text + "','" + comboHours.Text + "','" + txtSalary.Text + "','" + richTxtAddress.Text + "','" + comboQuestion.Text + "','" + txtAnswer.Text + "')";
                            string query1 = "";
                            query1 = "INSERT INTO [Login] (Username,Password,Status) VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "','Maid')";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            int result = cmd.ExecuteNonQuery();
                            SqlCommand cmd1 = new SqlCommand(query1, conn);
                            int result1 = cmd1.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Successfully added!!!", "Message");
                            }
                            else
                            {
                                MessageBox.Show("error!!!", "Message");
                            }
                            Clear();
                            conn.Close();
                        }
                    }
                }
            }
        }
        void Clear()
        {
            txtUsername.Text = txtName.Text = txtNid.Text = txtEmail.Text = txtPhone.Text = txtPassword.Text=comboWorkType.Text=comboHours.Text=txtSalary.Text= richTxtAddress.Text = comboQuestion.Text = txtAnswer.Text = "";
            radioBtnFemale.Checked = false;
            radioBtnMale.Checked = false;
        }
        private void comboQuestion_Enter(object sender, EventArgs e)
        {
            if (comboQuestion.Text == "Question")
            {
                comboQuestion.Text = "";
                comboQuestion.ForeColor = Color.Black;
            }
        }

        private void comboQuestion_Leave(object sender, EventArgs e)
        {
            if (comboQuestion.Text == "")
            {
                comboQuestion.Text = "Question";
                comboQuestion.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaidRegistration_Load(object sender, EventArgs e)
        {

        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboWorkType_Enter(object sender, EventArgs e)
        {
            if (comboWorkType.Text == "Work Type")
            {
                comboWorkType.Text = "";
                comboWorkType.ForeColor = Color.Black;
            }
        }

        private void comboWorkType_Leave(object sender, EventArgs e)
        {
            if (comboWorkType.Text == "")
            {
                comboWorkType.Text = "Work Type";
                comboWorkType.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboHours.Text == "Working Hours")
            {
                comboHours.Text = "";
                comboHours.ForeColor = Color.Black;
            }
        }

        private void comboHours_Leave(object sender, EventArgs e)
        {
            if (comboHours.Text == "")
            {
                comboHours.Text = "Working Hours";
                comboHours.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }
    }
}
