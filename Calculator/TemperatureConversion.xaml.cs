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
    /// Interaction logic for TemperatureConversion.xaml
    /// </summary>
    public partial class TemperatureConversion : Window
    {
        public TemperatureConversion()
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
            Celsius.Text = "";
            Fahrenheit.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            if (Celsius.Text != "")
            {
                if (double.TryParse(Celsius.Text, out double toDouble))
                {
                    double fahrenheitOperation = ((toDouble) * 9 / 5) + 32;
                    Fahrenheit.Text = fahrenheitOperation.ToString();
                }
                else
                {
                    MessageBox.Show("You must put a Number");
                }

            }
            else if (Fahrenheit.Text != "")
            {
                if (double.TryParse(Fahrenheit.Text, out double toDouble))
                {
                    double celsiusOperation = ((toDouble) - 32) * 5 / 9;
                    Celsius.Text = celsiusOperation.ToString();
                }
                else
                {
                    MessageBox.Show("You must put a Number");
                }
            }
        }
    }
}
