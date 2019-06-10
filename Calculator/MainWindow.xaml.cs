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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Equals_To(object sender, RoutedEventArgs e)
        {
            if (Box.Content == null)
            {
                MessageBox.Show("Something Went Wrong");
                return;
            }

            var display = "";
            var input = Box.Content.ToString();
            string[] myArr = input.Split('^');

            if (myArr.Length == 2)
            {
                if (double.TryParse(myArr[0], out double num1) && double.TryParse(myArr[1], out double num2))
                {
                    double output = 1;

                    for (double i = 1; i <= num2; i++)
                    {
                        output = num1 * output;
                    }

                    Box.Content = output;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }

                return;
            }

            (int? output1, decimal? output2, double? output3) = Box.Content.ToString().Calculate();

            if (!output1.HasValue && !output2.HasValue && !output3.HasValue)
            {
                MessageBox.Show("Something Went Wrong");
                return;
            }
            else if (output1.HasValue && !output2.HasValue && !output3.HasValue)
            {
                display = output1.ToString();
            }
            else if (!output1.HasValue && output2.HasValue && !output3.HasValue)
            {
                display = output2.ToString();
            }
            else if (!output1.HasValue && !output2.HasValue && output3.HasValue)
            {
                display = output3.ToString();
            }
            else
            {
                MessageBox.Show("An Unexpected Error Occured");
                return;
            }

            Box.Content = display;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Box.Content += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Box.Content += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Box.Content += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Box.Content += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Box.Content += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Box.Content += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Box.Content += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Box.Content += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Box.Content += "9";
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {
            Box.Content += "+";
        }

        private void Btn_Subtract(object sender, RoutedEventArgs e)
        {
            Box.Content += "-";
        }

        private void Btn_Multiply(object sender, RoutedEventArgs e)
        {
            Box.Content += "*";
        }

        private void Btn_Divide(object sender, RoutedEventArgs e)
        {
            Box.Content += "/";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Box.Content += "0";
        }

        private void Button_Click_Off(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_ClearAll(object sender, RoutedEventArgs e)
        {
            Box.Content = "";
        }

        private void Btn_Delete_One(object sender, RoutedEventArgs e)
        {
            if (Box.Content == null)
            {
                MessageBox.Show("Something Went Wrong");
                return;
            }

            var box = Box.Content.ToString();

            if (box != "")
            {
                Box.Content = box.Substring(0, box.Length - 1);
            }
        }

        private void Btn_Exponent(object sender, RoutedEventArgs e)
        {
            Box.Content += "^";
        }

        private void Btn_SqRoot(object sender, RoutedEventArgs e)
        {
            if (Box.Content == null)
            {
                MessageBox.Show("Something Went Wrong");
                return;
            }

            var value = Box.Content.ToString();
            decimal toDecimal = decimal.Parse(value);
            double result = (double)toDecimal;
            var output = Math.Sqrt(result);
            Box.Content = output;
        }

        private void Btn_Factorial(object sender, RoutedEventArgs e)
        {
            if (Box.Content == null)
            {
                MessageBox.Show("Something Went Wrong");
                return;
            }

            var input = Box.Content.ToString();
            double value = double.Parse(input);


            for (double i = value - 1; i >= 1; i--)
            {
                value = value * i;
            }

            Box.Content = value;
        }

        private void Btn_Modulas(object sender, RoutedEventArgs e)
        {
            Box.Content += "%";
        }

        private void Btn_Decimal(object sender, RoutedEventArgs e)
        {
            Box.Content += ".";
        }

        private void Btn_Menu(object sender, RoutedEventArgs e)
        {
            var menu = new Menu(this);
            menu.Activate();
            menu.Show();
        }
    }
}
