using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadLabel.Text = "123456789";
        }

        private void labelButton_Click(object sender, EventArgs e)
        {
            this.loadLabel.Text = "I love C#";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.button1.Visible = true;
        }
    }
}
