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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public MainWindow Window { get; set; }
        public Menu(MainWindow window)
        {
            Window = window;
            InitializeComponent();
        }

        private void Btn_Main(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Weight(object sender, RoutedEventArgs e)
        {
            var weightWindow = new WeightConversion();
            weightWindow.Activate();
            weightWindow.Show();
        }

        private void Btn_Time(object sender, RoutedEventArgs e)
        {
            var timeWindow = new TimeConversion();
            timeWindow.Activate();
            timeWindow.Show();
        }

        private void Btn_Length(object sender, RoutedEventArgs e)
        {
            var lengthWindow = new LenghtConversion();
            lengthWindow.Activate();
            lengthWindow.Show();
        }

        private void Btn_File(object sender, RoutedEventArgs e)
        {
            var fileWindow = new FileSizeConversion();
            fileWindow.Activate();
            fileWindow.Show();
        }

        private void Btn_Temperature(object sender, RoutedEventArgs e)
        {
            var tempWindow = new TemperatureConversion();
            tempWindow.Activate();
            tempWindow.Show();
        }

        private void Btn_Integer(object sender, RoutedEventArgs e)
        {
            var integerWindow = new IntegerConversion();
            integerWindow.Activate();
            integerWindow.Show();
        }

        private void Btn_Percent(object sender, RoutedEventArgs e)
        {
            var percentWindow = new PercentageConversion();
            percentWindow.Activate();
            percentWindow.Show();
        }
    }
}
