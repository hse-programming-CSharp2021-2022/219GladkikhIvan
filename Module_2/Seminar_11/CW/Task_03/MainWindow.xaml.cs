using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static StringBuilder str = new StringBuilder();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            str.Append(sender.ToString()[^1]);
            TextBlock1.Text = str.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            str.Remove(str.Length - 1, 1);
            TextBlock1.Text = str.ToString();
        }
    }
}
