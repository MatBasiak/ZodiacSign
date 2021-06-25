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

        private Tuple<string, string> getZosidacSign()
        {
            string[] zodiac_sign = new string[]
            {
                "Baran","Byk","Bliżnięta","Rak","Lew","Panna","Waga","Skorpion","Strzelec","Koziorożec","Wodnik","Ryby"
            };

            string[] zodiac_description = new string[]
            {
                "Jestem i działam, idę naprzód. Moim motto jest aktywność, agresja, przywództwo, początek",
                "Gromadzę i posiadam, doceniam roskoszuję się, Jestem stały, przyziemny, wytrzymały, zmysłowy",
                "Myślę i mówię, zbieram i przekazuję informacje. Jestem gadatliwy, ciekawski, towarzyski",
                "Czuję, przeżywam, martwię się, kontempluję. Jestem delikatny, konserwatywny, uczuciowy.",
                "Patrzcie na mnie i podziwiajcie - jestem w centrum uwagi. Wielkoduszność, autorytet, dramatyzm.",
                "Porządkuję i segreguję, pomagam i służę. Moje motto to staranność, krytyka, rezerwa, dbałość o zdrowie.",
                "Dążę do równowagi, sprawiedliwości i bezstronności. Jestem sprawiedliwy, wyrafinowany, dyplomatyczny.",
                "Zgłębiam, drążę, ujawniam. Moje motto to skupienie, głębia, zaborczość, wnikliwośc, intensywność",
                "Idę naprzód i przekraczam granice. Moje motto to optymizm, entuzjazm, przygoda, szczerość.",
                "Dążę do celu. Jestem konserwatywny, zdyscyplinowany, wytrwały, ambitny.",
                "Wolność i równość, przekraczanie granic. Moje motto to niezależność, humanitaryzm, wynalazczość.",
                "Ucieczka od rzeczywistości. Moje motto to intuicja, marzenia, sztuka, współczucie, iluzja."
            };




            string day_string = date.Substring(0, 2);
            int day = int.Parse(day_string);
            string month = date.Substring(3, 2);
            string result_zosiac_sign = "";
            string description = "";
            

            switch (month)
            {
                                    
                case "01": 
                    if (day >= 1 && day <= 19)
                    {
                        result_zosiac_sign = zodiac_sign[9];
                        description = zodiac_description[9];
                    }
                    if (day >= 20 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[10];
                        description = zodiac_description[10];
                    }
                    break;
                case "02": 
                    if (day >= 1 && day <= 18)
                    {
                        result_zosiac_sign = zodiac_sign[10];
                        description = zodiac_description[10];
                    }
                    if (day >= 19 && day <= 28)
                    {
                        result_zosiac_sign = zodiac_sign[11];
                        description = zodiac_description[11];
                    }
                    break;
                case "03": 
                    if (day >= 1 && day <= 20)
                    {
                        result_zosiac_sign = zodiac_sign[11];
                        description = zodiac_description[11];
                    }
                    if (day >= 21 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[0];
                        description = zodiac_description[0];
                    }
                    break;
                case "04": 
                    if (day >= 1 && day <= 19)
                    {
                        result_zosiac_sign = zodiac_sign[0];
                        description = zodiac_description[0];
                    }
                    if (day >= 20 && day <= 30)
                    {
                        result_zosiac_sign = zodiac_sign[1];
                        description = zodiac_description[1];
                    }
                    break;
                case "05": 
                    if (day >= 1 && day <= 20)
                    {
                        result_zosiac_sign = zodiac_sign[1];
                        description = zodiac_description[1];
                    }
                    if (day >= 21 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[2];
                        description = zodiac_description[2];
                    }
                    break;
                case "06": 
                    if (day >= 1 && day <= 20)
                    {
                        result_zosiac_sign = zodiac_sign[2];
                        description = zodiac_description[2];
                    }
                    if (day >= 21 && day <= 30)
                    {
                        result_zosiac_sign = zodiac_sign[3];
                        description = zodiac_description[3];
                    }
                    break;
                case "07": 
                    if (day >= 1 && day <= 22)
                    {
                        result_zosiac_sign = zodiac_sign[3];
                        description = zodiac_description[3];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[4];
                        description = zodiac_description[4];
                    }
                    break;
                case "08": 
                    if (day >= 1 && day <= 22)
                    {
                        result_zosiac_sign = zodiac_sign[4];
                        description = zodiac_description[4];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[5];
                        description = zodiac_description[5];
                    }
                    break;
                case "09": 
                    if (day >= 1 && day <= 22)
                    {
                        result_zosiac_sign = zodiac_sign[5];
                        description = zodiac_description[5];
                    }
                    if (day >= 23 && day <= 30)
                    {
                        result_zosiac_sign = zodiac_sign[6];
                        description = zodiac_description[6];
                    }
                    break;
                case "10": 
                    if (day >= 1 && day <= 22)
                    {
                        result_zosiac_sign = zodiac_sign[6];
                        description = zodiac_description[6];
                    }
                    if (day >= 23 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[7];
                        description = zodiac_description[7];
                    }
                    break;
                case "11": 
                    if (day >= 1 && day <= 21)
                    {
                        result_zosiac_sign = zodiac_sign[7];
                        description = zodiac_description[8];
                    }
                    if (day >= 22 && day <= 30)
                    {
                        result_zosiac_sign = zodiac_sign[8];
                        description = zodiac_description[8];
                    }
                    break;
                case "12": 
                    if (day >= 1 && day <= 21)
                    {
                        result_zosiac_sign = zodiac_sign[8];
                        description = zodiac_description[8];
                    }
                    if (day >= 22 && day <= 31)
                    {
                        result_zosiac_sign = zodiac_sign[9];
                        description = zodiac_description[9];
                    }
                    break;
                default:
                    result_zosiac_sign = "No correct value";
                    break;
            }

            Tuple<string,string> result =new Tuple<string,string> ( result_zosiac_sign, description );
            return result;

        }
    


           

        


        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {


            Tuple<string,string> zodiacSign = getZosidacSign();
            string sign = zodiacSign.Item1;
            string description = zodiacSign.Item2;
           
           MessageBox.Show($"Witaj {txtName.Text}! Twój znak zodiaku to {sign}.Motto :{description}");
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
