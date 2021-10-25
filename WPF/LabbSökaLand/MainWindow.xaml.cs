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



namespace LabbSökaLand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader;
        public MainWindow()
        {
            InitializeComponent();
            rader = File.ReadAllLines("./countries.csv");
        }



        private void Sök(object sender, RoutedEventArgs e)
        {

            // Läs in alla rader från textfilen countries.csv
            // Variabler
            int antal = 0;
            string sökterm = "";
            resultat.Text = "";

            // Avbryt programloop användaren matat in tomt dvs return

            // Fråga användare om en sökterm
            ingetSvar.Text = "Ange sökterm (avsluta med return)";
            sökterm = sökTerm.Text;

            // Loopa igenom alla rader
            for (var i = 1; i < rader.Length; i++)
            {
                // Dela upp raden
                string[] delar = rader[i].Split(',');

                // Plocka ut land
                string land = delar[1];

                // Plocka ut landskod
                string landskod = delar[2];

                // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                if (land.ToLower().Contains(sökterm.ToLower()))
                {
                    // Skriv ut matchande land och dess landskod
                    resultat.Text += $" {antal + 1}. {land} \n";
                    antal++;
                }
            }


            // Summering
            ingetSvar.Text = $"Hittade {antal} länder.";
        }
    }
}
