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
    public partial class MaidProfile : Form
    {
        DataSet ds = new DataSet();
        private DataAccess Da { get; set; }
        private Maid m1;
        public MaidProfile()
        {
            
        }
        public MaidProfile(Maid m1)
        {
            InitializeComponent();

            this.m1 = m1;
            string sql = "select * from [Request] where Maid_Username='"+m1.Username+"'";
            this.PopulateGridView(sql);
            this.dataGridView1.DataSource = this.ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.dataGridView1.AutoGenerateColumns = false;  //Optional false 
            this.ds = DataAccess.GetDataSet(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaidAccount ma = new MaidAccount(m1);
            this.Visible = false;
            ma.Visible = true;
        }

        private void MaidProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
