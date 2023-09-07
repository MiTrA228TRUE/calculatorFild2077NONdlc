using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        List<string> operations = new List<string> { "*", "/", "+", "-" };

        

        static double Calculate(string input)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(input, "");
            return Convert.ToDouble(result);
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            tb_input.Text += button.Content.ToString();
          
        }

        private void btDIV_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text += " / ";
        }

        private void btMUL_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text += " * ";
        }

        private void btPL_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text += " + ";
        }

        private void btMIN_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text += " - ";
        }

        private void tbRAW_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "RESULT";
            string str = tb_input.Text;
            double result = Calculate(tb_input.Text);

            tb_result.Text = Convert.ToString(Calculate(tb_input.Text));
        }

        private void btCLR_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text = "";
            tb_result.Text = "";
        }

        private void btC_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text = tb_input.Text.Substring(0, tb_input.Text.Length - 1);
        }
    }
}
