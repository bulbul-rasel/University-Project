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
    public partial class WhatWeOffer : Form
    {
        public WhatWeOffer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            this.Visible = false;
            hp.Visible = true;

        }

        private void WhatWeOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
