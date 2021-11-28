using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] strs = new string[] { "one", "two", "three" };
        private void initButton_Click(object sender, EventArgs e)
        {
            textBox.Lines = strs;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var str2 = textBox.Lines;
            var strJoin = String.Join(" ", str2);
            MessageBox.Show(strJoin);
        }
    }
}
