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
    /// Interaction logic for PercentageConversion.xaml
    /// </summary>
    public partial class PercentageConversion : Window
    {
        public PercentageConversion()
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
            Decimal.Text = "";
            Percent.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            if (Decimal.Text != "")
            {
                if (double.TryParse(Decimal.Text, out double toDouble))
                {
                    double percentOperation = toDouble * 100;
                    Percent.Text = percentOperation.ToString();
                }
                else
                {
                    MessageBox.Show("You must put a Number");
                }
            }
            else if (Percent.Text != "")
            {
                if (double.TryParse(Percent.Text, out double toDouble))
                {
                    double decimalOperation = toDouble / 100;
                    Decimal.Text = decimalOperation.ToString();
                }
                else
                {
                    MessageBox.Show("You must put a Number");
                }
            }
        }
    }
}
