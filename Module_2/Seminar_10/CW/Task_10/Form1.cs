using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        class Rate
        {
            public static uint Hits { get; set; }
            public static uint Fails { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            label2.Text = (++Rate.Hits).ToString();
            buttonCheck.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = (++Rate.Fails).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonCheck.Visible = !buttonCheck.Visible;
        }
    }
}
