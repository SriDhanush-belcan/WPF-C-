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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int First;
        int Second;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Textresult.Text += btn.Content.ToString();
            Second = Int32.Parse(Textresult.Text);
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(Textresult.Text);
            op = '+';
            Textresult.Clear();
        }

        private void Divide_Click_1(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(Textresult.Text);
            op = '/';
            Textresult.Clear();
        }

        private void Subtractbutton_Click(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(Textresult.Text);
            op = '-';
            Textresult.Clear();
        }

        private void Multiplybutton_Click(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(Textresult.Text);
            op = '*';
            Textresult.Clear();
        }

        private void Equalsbutton_Click(object sender, RoutedEventArgs e)
        {
            Second = Int32.Parse(Textresult.Text);
            int result = 0;

            if (op == '+')
            {
                result = First + Second;
            }
            else if (op == '-')
            {
                result = First - Second;
            }
            else if (op == '*')
            {
                result = First * Second;
            }
            else if (op == '/')
            {
                result = First / Second;
            }
            if (Textresult.Text == "0")
            {
                Textresult.Clear();
            }
            Textresult.Text = result.ToString();
        }

        private void Clearbutton_Click(object sender, RoutedEventArgs e)
        {
            Textresult.Text = " ";
        }
    }
}
