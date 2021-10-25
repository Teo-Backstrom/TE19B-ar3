using System;
using System.IO;
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

namespace gästbok
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
        private void Sök(object sender, RoutedEventArgs e)
        {

            // Gästboksfilen
            string filen = "./guestbook.txt";

            // Läs in gästboksfilen
            string allText = "";
            if (File.Exists(filen))
            {
                allText = File.ReadAllText(filen);
                resultat.Text = allText;


                string inlägg = text.Text;
                string namnet = namn.Text;

                // Lägg till inlägget
                allText += namnet + ": " + inlägg + "\n";

                // Spara in gästboksfilen
                File.WriteAllText(filen, allText);

                // Respons till användaren
                allText = File.ReadAllText(filen);
                resultat.Text = allText;

            }
            else
            {
                ingetSvar.Text = $"{filen} finns inte, avbryter...";
            }



        }
    }
}
