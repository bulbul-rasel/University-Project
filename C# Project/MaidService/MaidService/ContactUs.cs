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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Visible = false;
            hp.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContactUs_Load(object sender, EventArgs e)
        {

        }
    }
}
