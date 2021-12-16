using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X = Y = 0;
            W = H = 100;
            trackBar1.Maximum = Width - W - 100;
            trackBar2.Maximum = Height - H - 100;
            trackBar2.Value = trackBar2.Maximum;
        }

        int X, Y, W, H;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = trackBar2.Maximum - trackBar2.Value;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            TransparencyKey = SystemColors.ControlDark;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            Invalidate();
        }
    }
}
