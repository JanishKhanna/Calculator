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
    /// Interaction logic for FileSizeConversion.xaml
    /// </summary>
    public partial class FileSizeConversion : Window
    {
        public FileSizeConversion()
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
            Bytes.Text = "";
            Kb.Text = "";
            Mb.Text = "";
            Gb.Text = "";
            Tb.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Bytes.Text != "")
                {
                    double kilobytesOperation = Convert.ToDouble(Bytes.Text) / 1000;
                    Kb.Text = kilobytesOperation.ToString();

                    double megabytesOperation = Convert.ToDouble(Bytes.Text) / 1000000;
                    Mb.Text = megabytesOperation.ToString();

                    double gigabytesOperation = Convert.ToDouble(Bytes.Text) / 1000000000;
                    Gb.Text = gigabytesOperation.ToString();

                    double terabytesOperation = Convert.ToDouble(Bytes.Text) / 1000000000000;
                    Tb.Text = terabytesOperation.ToString();
                }
                else if (Kb.Text != "")
                {
                    double bytesOperation = Convert.ToDouble(Kb.Text) * 1000;
                    Bytes.Text = bytesOperation.ToString();

                    double megabytesOperation = Convert.ToDouble(Kb.Text) / 1000;
                    Mb.Text = megabytesOperation.ToString();

                    double gigabytesOperation = Convert.ToDouble(Kb.Text) / 1000000;
                    Gb.Text = gigabytesOperation.ToString();

                    double terabytesOperation = Convert.ToDouble(Kb.Text) / 1000000000;
                    Tb.Text = terabytesOperation.ToString();
                }
                else if (Mb.Text != "")
                {
                    double bytesOperation = Convert.ToDouble(Mb.Text) * 1000000;
                    Bytes.Text = bytesOperation.ToString();

                    double kilobytesOperation = Convert.ToDouble(Mb.Text) * 1000;
                    Kb.Text = kilobytesOperation.ToString();

                    double gigabytesOperation = Convert.ToDouble(Mb.Text) / 1000;
                    Gb.Text = gigabytesOperation.ToString();

                    double terabytesOperation = Convert.ToDouble(Mb.Text) / 1000000;
                    Tb.Text = terabytesOperation.ToString();
                }
                else if (Gb.Text != "")
                {
                    double bytesOperation = Convert.ToDouble(Gb.Text) * 1000000000;
                    Bytes.Text = bytesOperation.ToString();

                    double kilobytesOperation = Convert.ToDouble(Gb.Text) * 1000000;
                    Kb.Text = kilobytesOperation.ToString();

                    double megabytesOperation = Convert.ToDouble(Gb.Text) * 1000;
                    Mb.Text = megabytesOperation.ToString();

                    double terabytesOperation = Convert.ToDouble(Gb.Text) / 1000;
                    Tb.Text = terabytesOperation.ToString();
                }
                else if (Tb.Text != "")
                {
                    double bytesOperation = Convert.ToDouble(Tb.Text) * 1000000000000;
                    Bytes.Text = bytesOperation.ToString();

                    double kilobytesOperation = Convert.ToDouble(Tb.Text) * 1000000000;
                    Kb.Text = kilobytesOperation.ToString();

                    double megabytesOperation = Convert.ToDouble(Tb.Text) * 1000000;
                    Mb.Text = megabytesOperation.ToString();

                    double gigabytesOperation = Convert.ToDouble(Tb.Text) * 1000;
                    Gb.Text = gigabytesOperation.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must put a Number");
            }
        }
    }
}
