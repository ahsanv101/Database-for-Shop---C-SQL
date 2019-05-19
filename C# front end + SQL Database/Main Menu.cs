using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction T = new Transaction();
            T.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Frm = new Form2();
            Frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report R = new Report();
            R.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchItems S = new SearchItems();
            S.Show();
        }
    }


}
