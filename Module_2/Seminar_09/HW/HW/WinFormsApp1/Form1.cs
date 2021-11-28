using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string> strs = new List<string>() {"один", "два",
            "три", "четыре", "пять", "шесть", "семь"};
        private void buttonInit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var el in strs)
                listBox1.Items.Add(el);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Список пуст или нет выделенного элемента");
            }
        }
    }
}
