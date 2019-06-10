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
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for IntegerConversion.xaml
    /// </summary>
    public partial class IntegerConversion : Window
    {
        public IntegerConversion()
        {
            InitializeComponent();
        }

        private void Btn_Menu(object sender, RoutedEventArgs e)
        {
            var mainWindow = App.Current.MainWindow as MainWindow;
            var menu = new Menu(mainWindow);
            menu.Activate();
            menu.Show();
        }

        private void Btn_Reset(object sender, RoutedEventArgs e)
        {
            Binary.Text = "";
            Octal.Text = "";
            Hexadecimal.Text = "";
            Integer.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Integer.Text != "")
                {
                    if (int.TryParse(Integer.Text, out int toInt))
                    {
                        var binaryOperation = Convert.ToString(toInt, 2);
                        Binary.Text = binaryOperation;

                        var octalOperation = Convert.ToString(toInt, 8);
                        Octal.Text = octalOperation;

                        var hexadecimalOperation = Convert.ToString(toInt, 16);
                        Hexadecimal.Text = hexadecimalOperation;
                    }
                    else
                    {
                        MessageBox.Show("Please Input a number");
                    }
                }
                else if (Binary.Text != "")
                {
                    int binaryToInt;
                    try
                    {
                        binaryToInt = Convert.ToInt32(Binary.Text, 2);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please put a valid Binary Number");
                        return;
                    }

                    Integer.Text = binaryToInt.ToString();

                    var octalOperation = Convert.ToString(binaryToInt, 8);
                    Octal.Text = octalOperation;

                    var hexadecimalOperation = Convert.ToString(binaryToInt, 16);
                    Hexadecimal.Text = hexadecimalOperation;
                }
                else if (Octal.Text != "")
                {
                    int octalToInt;

                    try
                    {
                        octalToInt = Convert.ToInt32(Octal.Text, 8);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Octal Numbers cannot have letters and also the number 8 and 9");
                        return;
                    }

                    Integer.Text = octalToInt.ToString();

                    var binaryOperation = Convert.ToString(octalToInt, 2);
                    Binary.Text = binaryOperation;

                    var hexadecimalOperation = Convert.ToString(octalToInt, 16);
                    Hexadecimal.Text = hexadecimalOperation;
                }
                else if (Hexadecimal.Text != "")
                {
                    int hexadecimalToInt;

                    try
                    {
                        hexadecimalToInt = Convert.ToInt32(Hexadecimal.Text, 16);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("You can only input A,B,C,D,E,F and the Digits");
                        return;
                    }

                    Integer.Text = hexadecimalToInt.ToString();

                    var binaryOperation = Convert.ToString(hexadecimalToInt, 2);
                    Binary.Text = binaryOperation;

                    var octalOperation = Convert.ToString(hexadecimalToInt, 8);
                    Octal.Text = octalOperation;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must put a Number");
            }
        }
    }
}
