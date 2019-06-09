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
//using System.Linq;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for WeightConversion.xaml
    /// </summary>
    public partial class WeightConversion : Window
    {
        public WeightConversion()
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
            Mg.Text = "";
            Gram.Text = "";
            Kg.Text = "";
            Ounces.Text = "";
            Pounds.Text = "";
        }

        private void Btn_Submit(object sender, RoutedEventArgs e)
        {
            if(Mg.Text != "")
            {
                double gramOperation = Convert.ToDouble(Mg.Text) / 1000;
                Gram.Text = gramOperation.ToString();

                double kgOperation = Convert.ToDouble(Mg.Text) / 1000000;
                Kg.Text = kgOperation.ToString();

                double ounceOperation = Convert.ToDouble(Mg.Text) / 28349.52;
                Ounces.Text = ounceOperation.ToString();

                double poundOperation = Convert.ToDouble(Mg.Text) / 453592.37;
                Pounds.Text = poundOperation.ToString();
            }
            else if(Gram.Text != "")
            {
                double mgOperation = Convert.ToDouble(Gram.Text) * 1000;
                Mg.Text = mgOperation.ToString();

                double kgOperation = Convert.ToDouble(Gram.Text) / 1000;
                Kg.Text = kgOperation.ToString();

                double ounceOperation = Convert.ToDouble(Gram.Text) / 28.35;
                Ounces.Text = ounceOperation.ToString();

                double poundOperation = Convert.ToDouble(Gram.Text) / 453.592;
                Pounds.Text = poundOperation.ToString();
            }
            else if(Kg.Text != "")
            {
                double mgOperation = Convert.ToDouble(Kg.Text) * 1000000;
                Mg.Text = mgOperation.ToString();

                double gramOperation = Convert.ToDouble(Kg.Text) * 1000;
                Gram.Text = gramOperation.ToString();

                double ounceOperation = Convert.ToDouble(Kg.Text) * 35.274;
                Ounces.Text = ounceOperation.ToString();

                double poundOperation = Convert.ToDouble(Kg.Text) * 2.205;
                Pounds.Text = poundOperation.ToString();
            }
            else if (Ounces.Text != "")
            {
                double mgOperation = Convert.ToDouble(Ounces.Text) * 28349.523;
                Mg.Text = mgOperation.ToString();

                double gramOperation = Convert.ToDouble(Ounces.Text) * 28.35;
                Gram.Text = gramOperation.ToString();

                double kgOperation = Convert.ToDouble(Ounces.Text) / 35.274;
                Kg.Text = kgOperation.ToString();

                double poundOperation = Convert.ToDouble(Ounces.Text) / 16;
                Pounds.Text = poundOperation.ToString();
            }
            else if (Pounds.Text != "")
            {
                double mgOperation = Convert.ToDouble(Pounds.Text) * 453592.37;
                Mg.Text = mgOperation.ToString();

                double gramOperation = Convert.ToDouble(Pounds.Text) * 453.592;
                Gram.Text = gramOperation.ToString();

                double kgOperation = Convert.ToDouble(Pounds.Text) / 2.205;
                Kg.Text = kgOperation.ToString();

                double ounceOperation = Convert.ToDouble(Pounds.Text) * 16;
                Ounces.Text = ounceOperation.ToString();
            }
        }
    }
}
