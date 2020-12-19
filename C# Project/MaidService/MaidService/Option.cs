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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            this.Visible = false;
            h.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistration f3 = new UserRegistration();
            this.Visible = false;
            f3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaidRegistration m = new MaidRegistration();
            this.Visible = false;
            m.Visible = true;
        }

        private void Option_Load(object sender, EventArgs e)
        {

        }

       
    }
}
