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
    public partial class Homepage : Form
    {
        public Homepage()
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
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit!", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WhatWeOffer wh = new WhatWeOffer();
            this.Visible = false;
            wh.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WhyUs wh = new WhyUs();
            this.Visible = false;
            wh.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContactUs cu = new ContactUs();
            this.Visible = false;
            cu.Visible = true;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
