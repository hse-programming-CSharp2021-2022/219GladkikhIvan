using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int opt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opt == 0)
            {
                try
                {
                    label.Text = label.Text[..^1];
                }
                catch
                {
                    opt++;
                    timer1.Interval = 10;
                }   
            }
            else if (opt == 1)
            {
                this.Opacity -= 0.001;
                if (this.Opacity == 0)
                    opt++;
            }
            else if (opt == 2)
            {
                label.Text = "Кот уже ушёл!";
                opt++;
            }
            else
            {
                this.Opacity += 0.001;
            }
        }
    }
}
