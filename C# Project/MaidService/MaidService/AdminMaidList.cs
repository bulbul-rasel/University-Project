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
    public partial class AdminMaidList : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ap;
        public AdminMaidList(Admin ap)
        {
            InitializeComponent();
            this.ap = ap;
            string sql = "select * from [Maid]";
            this.PopulateGridView(sql);
            this.GridMaidList.DataSource = this.Ds.Tables[0];
            //button false
            btnDelete.Enabled = false;
            //txt fild false
            txtUsername.Enabled = false;
            txtName.Enabled = false;
            txtNid.Enabled = false;
            txtEmail.Enabled = false;
            txtGender.Enabled = false;
            txtPhone.Enabled = false;
            txtWorkType.Enabled = false;
            txtHours.Enabled = false;
            txtSalary.Enabled = false;
            txtAddress.Enabled = false;
        }
        void PopulateGridView(string sql)
        {
            this.GridMaidList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile a = new AdminProfile(ap);
            this.Visible = false;
            a.Visible = true;
        }

        private void GridMaidList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUsername.Text = this.GridMaidList.CurrentRow.Cells["Username"].Value.ToString();
            this.txtName.Text = this.GridMaidList.CurrentRow.Cells["name"].Value.ToString();
            this.txtNid.Text = this.GridMaidList.CurrentRow.Cells["Nid"].Value.ToString();
            this.txtEmail.Text = this.GridMaidList.CurrentRow.Cells["Email"].Value.ToString();
            this.txtGender.Text = this.GridMaidList.CurrentRow.Cells["Gender"].Value.ToString();
            this.txtPhone.Text = this.GridMaidList.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtAddress.Text = this.GridMaidList.CurrentRow.Cells["Address"].Value.ToString();
            this.txtWorkType.Text = this.GridMaidList.CurrentRow.Cells["Work_Type"].Value.ToString();
            this.txtHours.Text = this.GridMaidList.CurrentRow.Cells["Working_Hours"].Value.ToString();
            this.txtSalary.Text = this.GridMaidList.CurrentRow.Cells["Salary"].Value.ToString();
            // MessageBox.Show("Data has been pushed from grid!");
            btnDelete.Enabled = true;
            // btnSave.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Username = this.GridMaidList.CurrentRow.Cells["Username"].Value.ToString();
            string Name = this.GridMaidList.CurrentRow.Cells["name"].Value.ToString();
            string sql = "delete from [Maid] where Username='" + Username + "';";
            string sqll = "delete from [Login] where Username='" + Username + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(Username + " has been deleted.");
            string sql1 = "select * from [Maid]";
            this.PopulateGridView(sql1);
            this.GridMaidList.DataSource = this.Ds.Tables[0];
            btnDelete.Enabled = false;
            txtUsername.Clear();
            txtName.Clear();
            txtNid.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtWorkType.Clear();
            txtHours.Clear();
            txtSalary.Clear();
            txtAddress.Clear();
        }

        private void AdminMaidList_Load(object sender, EventArgs e)
        {

        }
    }
}
