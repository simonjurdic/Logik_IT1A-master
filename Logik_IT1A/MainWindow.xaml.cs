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

namespace Logik_IT1A
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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)

        {
            Ellipse ellipse = (Ellipse)sender;//přetypování na Ellipse
            if (ellipse.Fill.ToString() == "#FFF7F7F7")
            {
                ellipse.Fill = Brushes.Red;
            }
            else if (ellipse.Fill.ToString() == Brushes.Red.ToString())
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill.ToString() == Brushes.Green.ToString())
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill.ToString() == Brushes.Blue.ToString())
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill.ToString() == Brushes.Yellow.ToString())
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill.ToString() == Brushes.Orange.ToString())
            {
                ellipse.Fill = Brushes.Purple;
            }
            else
            {
                ellipse.Fill = Brushes.Red;


            }
        }

        private void NastavKoloDisabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Stroke = Brushes.Gray;
            ellipse.Fill = Brushes.White;

        }




        private void Prvnikolo()
        {
            Kruh_0_0.IsEnabled = true;
            Kruh_0_1.IsEnabled = true;
            Kruh_0_2.IsEnabled = true;
            Kruh_0_3.IsEnabled = true;


            NastavKoloDisabled(Kruh_1_0)
            NastavKoloDisabled(Kruh_1_0)

            Kruh_1_0.IsEnabled = false;
            Kruh_1_1.IsEnabled = false;
            Kruh_1_2.IsEnabled = false;
            Kruh_1_3.IsEnabled = false;

            Kruh_2_0.IsEnabled = false;
            Kruh_2_1.IsEnabled = false;
            Kruh_2_2.IsEnabled = false;
            Kruh_2_3.IsEnabled = false;

            Kruh_3_0.IsEnabled = false;
            Kruh_3_1.IsEnabled = false;
            Kruh_3_2.IsEnabled = false;
            Kruh_3_3.IsEnabled = false;

            Kruh_4_0.IsEnabled = false;
            Kruh_4_1.IsEnabled = false;
            Kruh_4_2.IsEnabled = false;
            Kruh_4_3.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
      
    }
}
