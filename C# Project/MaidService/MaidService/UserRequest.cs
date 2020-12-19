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
    public partial class UserRequest : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ad;
        public UserRequest(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string sql = "select * from [Request]";
            this.PopulateGridView(sql);
            this.GridRequestList.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridRequestList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile a = new AdminProfile(ad);
            this.Visible = false;
            a.Visible = true;
        }

        private void UserRequest_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Maid_Username = this.GridRequestList.CurrentRow.Cells["Maid_Username"].Value.ToString();
            string sql = "delete from [Request] where Maid_Username='" + Maid_Username + "';";
            DataAccess.ExecuteQuery(sql);
            MessageBox.Show(Maid_Username + " has been deleted.");
            string sql1 = "select * from [Request]";
            this.PopulateGridView(sql1);
            this.GridRequestList.DataSource = this.Ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from [Request]";
            this.PopulateGridView(sql1);
            this.GridRequestList.DataSource = this.Ds.Tables[0];
        }
    }
}
