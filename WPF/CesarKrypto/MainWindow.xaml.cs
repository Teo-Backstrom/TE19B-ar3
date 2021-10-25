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

namespace CesarKrypto
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

        private void Skicka_Click(object sender, RoutedEventArgs e)
        {

            string text = inmatningText.Text;

            string nyckelString = inmatningNyckel.Text;

            int nyckel = 0;
            if (!int.TryParse(nyckelString, out nyckel))
            {
                textruta.Text += " \n Du måste mata in en int, Försök igen: ";
            }

            string kryptadText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char bokstav = text[i];
                //  textruta.Text+=" \n Bokstaven på position " + i + " är " + bokstav;

                int ascii = (int)bokstav;
                // textruta.Text+=  "\n" + bokstav + " är "+ ascii;

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);
                //textruta.Text += " \n " + bokstav+ " blir " + kryptadBokstav;

                kryptadText += kryptadBokstav.ToString();
            }
            if (int.TryParse(nyckelString, out nyckel))
            {
                textruta.Text += " \n Den krypterade texten blir: " + kryptadText;
            }

        }


    }
}
