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
    /// Interaction logic for TimeConversion.xaml
    /// </summary>
    public partial class TimeConversion : Window
    {
        public TimeConversion()
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
            Sec.Text = "";
            Min.Text = "";
            Hrs.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Sec.Text != "")
                {
                    var minuteOperation = Convert.ToDecimal(Sec.Text) / 60;
                    Min.Text = minuteOperation.ToString();

                    var hourOperation = Convert.ToDecimal(Sec.Text) / 3600;
                    Hrs.Text = hourOperation.ToString();
                }
                else if (Min.Text != "")
                {
                    var secondOperation = Convert.ToDecimal(Min.Text) * 60;
                    Sec.Text = secondOperation.ToString();

                    var hourOperation = Convert.ToDecimal(Min.Text) / 60;
                    Hrs.Text = hourOperation.ToString();
                }
                else if (Hrs.Text != "")
                {
                    var secondOperation = Convert.ToDecimal(Hrs.Text) * 3600;
                    Sec.Text = secondOperation.ToString();

                    var minuteOperation = Convert.ToDecimal(Hrs.Text) * 60;
                    Min.Text = minuteOperation.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must put a Number");
            }
        }
    }
}
