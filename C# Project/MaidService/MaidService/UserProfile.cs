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

    public partial class UserProfile : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        DataSet ds = new DataSet();
        private User u1;
        public UserProfile()
        {
            
        }
        public UserProfile(User u1)
        {
            InitializeComponent();

            this.u1 = u1;
            string sql = "select * from [Maid]";
            this.PopulateGridView(sql);
            this.GridMaidList.DataSource = this.Ds.Tables[0];

        }
        void PopulateGridView(string sql)
        {
            this.GridMaidList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAccount ua = new UserAccount(u1);
            this.Visible = false;
            ua.Visible = true;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select Maid_Username from Request where Maid_Username='" + this.txtMaidUsername.Text + "';";
            this.Ds = DataAccess.GetDataSet(sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show(this, "This Maid is already selected");
            }
            else
            {
                string sql1 = @"insert into [Request] (Maid_Username,Maid_Name,Work_Type,User_Username,User_Name,User_Address,User_Phone) values ('" + txtMaidUsername.Text + "','" + txtMaidName.Text + "','" + txtMaidWorkType.Text + "','" + u1.Username + "','" + u1.Name + "','"+u1.Address+"','"+u1.Phone+"')";
                DataAccess.ExecuteQuery(sql1);
                MessageBox.Show("Successfully Selected!", "Message");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridMaidList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMaidUsername.Text = this.GridMaidList.CurrentRow.Cells["Username"].Value.ToString();
            this.txtMaidName.Text = this.GridMaidList.CurrentRow.Cells["name"].Value.ToString();
            this.txtMaidWorkType.Text = this.GridMaidList.CurrentRow.Cells["Work_Type"].Value.ToString();
            
        }
    }
}
