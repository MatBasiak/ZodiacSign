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

namespace ZodiacSign
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

        string date;

        private string getZosidacSign()
        {

            
            return date;

        }


        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {


            string zodiacSign = getZosidacSign();
            MessageBox.Show($"Witaj {txtName.Text}! Twój znak zodiaku to {zodiacSign}");
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
        }

        private void Calendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            date = calendar.SelectedDate.ToString();
            
        }
    }
}
