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
    public partial class AdminProfile : Form
    {
        DataSet ds = new DataSet();
        private Admin ad;
        public AdminProfile()
        {
           
        }
        public AdminProfile(Admin ad)
        {
            InitializeComponent();

            this.ad = ad;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AdminAccount c = new AdminAccount(ad);
            this.Visible = false;
            c.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminUserList au = new AdminUserList(ad);
            this.Visible = false;
            au.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMaidList au = new AdminMaidList(ad);
            this.Visible = false;
            au.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserRequest u = new UserRequest(ad);
            this.Visible = false;
            u.Visible = true;
        }
    }
}
