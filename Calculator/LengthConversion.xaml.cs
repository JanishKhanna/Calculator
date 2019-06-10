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
    /// Interaction logic for LenghtConversion.xaml
    /// </summary>
    public partial class LenghtConversion : Window
    {
        public LenghtConversion()
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
            Mm.Text = "";
            Cm.Text = "";
            Meter.Text = "";
            Km.Text = "";
            Inches.Text = "";
            Feet.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Mm.Text != "")
                {
                    double centimeterOperation = Convert.ToDouble(Mm.Text) / 10;
                    Cm.Text = centimeterOperation.ToString();

                    double meterOperation = Convert.ToDouble(Mm.Text) / 1000;
                    Meter.Text = meterOperation.ToString();

                    double kilometerOperation = Convert.ToDouble(Mm.Text) / 1000000;
                    Km.Text = kilometerOperation.ToString();

                    double inchesOperation = Convert.ToDouble(Mm.Text) / 25.4;
                    Inches.Text = inchesOperation.ToString();

                    double feetOperation = Convert.ToDouble(Mm.Text) / 304.8;
                    Feet.Text = feetOperation.ToString();
                }
                else if (Cm.Text != "")
                {
                    double milimeterOperation = Convert.ToDouble(Cm.Text) * 10;
                    Mm.Text = milimeterOperation.ToString();

                    double meterOperation = Convert.ToDouble(Cm.Text) / 100;
                    Meter.Text = meterOperation.ToString();

                    double kilometerOperation = Convert.ToDouble(Cm.Text) / 100000;
                    Km.Text = kilometerOperation.ToString();

                    double inchesOperation = Convert.ToDouble(Cm.Text) / 2.54;
                    Inches.Text = inchesOperation.ToString();

                    double feetOperation = Convert.ToDouble(Cm.Text) / 30.48;
                    Feet.Text = feetOperation.ToString();
                }
                else if (Meter.Text != "")
                {
                    double milimeterOperation = Convert.ToDouble(Meter.Text) * 1000;
                    Mm.Text = milimeterOperation.ToString();

                    double centimeterOperation = Convert.ToDouble(Meter.Text) * 100;
                    Cm.Text = centimeterOperation.ToString();

                    double kilometerOperation = Convert.ToDouble(Meter.Text) / 1000;
                    Km.Text = kilometerOperation.ToString();

                    double inchesOperation = Convert.ToDouble(Meter.Text) * 39.37;
                    Inches.Text = inchesOperation.ToString();

                    double feetOperation = Convert.ToDouble(Meter.Text) * 3.281;
                    Feet.Text = feetOperation.ToString();
                }
                else if (Km.Text != "")
                {
                    double milimeterOperation = Convert.ToDouble(Km.Text) * 1000000;
                    Mm.Text = milimeterOperation.ToString();

                    double centimeterOperation = Convert.ToDouble(Km.Text) * 100000;
                    Cm.Text = centimeterOperation.ToString();

                    double meterOperation = Convert.ToDouble(Km.Text) * 1000;
                    Meter.Text = meterOperation.ToString();

                    double inchesOperation = Convert.ToDouble(Km.Text) * 39370.079;
                    Inches.Text = inchesOperation.ToString();

                    double feetOperation = Convert.ToDouble(Km.Text) * 3280.84;
                    Feet.Text = feetOperation.ToString();
                }
                else if (Inches.Text != "")
                {
                    double milimeterOperation = Convert.ToDouble(Inches.Text) * 25.4;
                    Mm.Text = milimeterOperation.ToString();

                    double centimeterOperation = Convert.ToDouble(Inches.Text) * 2.54;
                    Cm.Text = centimeterOperation.ToString();

                    double meterOperation = Convert.ToDouble(Inches.Text) / 39.37;
                    Meter.Text = meterOperation.ToString();

                    double kilometerOperation = Convert.ToDouble(Inches.Text) / 39370.079;
                    Km.Text = kilometerOperation.ToString();

                    double feetOperation = Convert.ToDouble(Inches.Text) / 12;
                    Feet.Text = feetOperation.ToString();
                }
                else if (Feet.Text != "")
                {
                    double milimeterOperation = Convert.ToDouble(Feet.Text) * 304.8;
                    Mm.Text = milimeterOperation.ToString();

                    double centimeterOperation = Convert.ToDouble(Feet.Text) * 30.48;
                    Cm.Text = centimeterOperation.ToString();

                    double meterOperation = Convert.ToDouble(Feet.Text) / 3.281;
                    Meter.Text = meterOperation.ToString();

                    double kilometerOperation = Convert.ToDouble(Feet.Text) / 3280.84;
                    Km.Text = kilometerOperation.ToString();

                    double inchesOperation = Convert.ToDouble(Feet.Text) * 12;
                    Inches.Text = inchesOperation.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must put a Number");
            }
        }
    }
}
