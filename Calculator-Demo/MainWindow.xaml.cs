using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator_Demo
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

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            // bodya sposib test
            string res = (new DataTable().Compute((txtBlock.Text).Replace(',', '.'), null)).ToString();
            txtBlock.Text = res;
        }

        private void btnNum_Click(object sender, RoutedEventArgs e)
        {
            this.txtBlock.Text += ((Button)sender).Content.ToString();
        }


        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text += '+';
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text += '-';
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = txtBlock.Text.Remove(txtBlock.Text.Length - 1, 1);
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text += '*';
        }
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text += '/';
        }

        private void btnComa_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text += ',';
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "0";
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            // need development
        }
    }
}
