using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            var max = this.MaximumSize;
            var min = this.MaximumSize;
            var curr = this.Size;
            var mode = curr == min;

            if (mode)
            {
                buttonSize.Text = "Увеличить форму";
                this.Size = new Size(Math.Min(this.Size.Width + 50, max.Width), Math.Min(this.Size.Height + 50, max.Height));
            }
            else
            {
                buttonSize.Text = "Уменьшить форму";
                this.Size = new Size(Math.Max(this.Size.Width - 50, min.Width), Math.Max(this.Size.Height - 50, min.Height));
            }
        }
    }
}
