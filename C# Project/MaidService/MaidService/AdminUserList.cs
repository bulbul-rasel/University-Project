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
    public partial class AdminUserList : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ad;
        public AdminUserList(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string sql = "select * from [User]";
            this.PopulateGridView(sql);
            this.GridUserList.DataSource = this.Ds.Tables[0];

            //button false
            btnDelete.Enabled = false;
            //txt fild false
            txtUsername.Enabled = false;
            txtName.Enabled = false;
            txtNid.Enabled = false;
            txtEmail.Enabled = false;
            txtGender.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
        }
        void PopulateGridView(string sql)
        {
            this.GridUserList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }

        private void AdminUserList_Load(object sender, EventArgs e)
        {

        }

        private void GridUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUsername.Text= this.GridUserList.CurrentRow.Cells["Username"].Value.ToString();
            this.txtName.Text = this.GridUserList.CurrentRow.Cells["name"].Value.ToString();
            this.txtNid.Text = this.GridUserList.CurrentRow.Cells["Nid"].Value.ToString();
            this.txtEmail.Text = this.GridUserList.CurrentRow.Cells["Email"].Value.ToString();
            this.txtGender.Text = this.GridUserList.CurrentRow.Cells["Gender"].Value.ToString();
            this.txtPhone.Text = this.GridUserList.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtAddress.Text = this.GridUserList.CurrentRow.Cells["Address"].Value.ToString();
            // MessageBox.Show("Data has been pushed from grid!");
            btnDelete.Enabled = true;
            // btnSave.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Username = this.GridUserList.CurrentRow.Cells["Username"].Value.ToString();
            string Name = this.GridUserList.CurrentRow.Cells["name"].Value.ToString();
            string sql = "delete from [User] where Username='" + Username + "';";
            string sqll = "delete from [Login] where Username='" + Username + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(Username + " has been deleted.");
            string sql1 = "select * from [User]";
            this.PopulateGridView(sql1);
            this.GridUserList.DataSource = this.Ds.Tables[0];
            btnDelete.Enabled = false;
            txtUsername.Clear();
            txtName.Clear();
            txtNid.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
           
        }
    }
}
