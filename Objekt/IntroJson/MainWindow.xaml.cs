using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Text.RegularExpressions;

namespace IntroJson
{
    class Kontakt
    {
        public string Namn;
        public string Mobil;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Gästboksfilen
        string filen = "./kontakter.tsv";

        // Kontaktlistan
        List<string> kontaktLista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            // Lägg fokus i första inmatningsrutan
            rutaNamn.Focus();

            // Läs in Kontaktlistan
            if (File.Exists(filen))
            {
                kontaktLista = File.ReadAllLines(filen).ToList();
            }
            else
            {
                rutaStatus.Text = "Filen finns inte";
            }

            // fyll på textrutan för alla kontakter
            foreach (var kontakten in kontaktLista)
            {
                rutaAllaKontakter.Text += kontakten + "\n";
            }
        }

        private void ClickSpara(object sender, RoutedEventArgs e)
        {
            // Hämta namn & mobil
            string namn = rutaNamn.Text;
            string mobil = rutaMobil.Text;

            // KOlla att mobilnr är ok
            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-]([0-9]{7})$");
            if (regex.IsMatch(mobil))
            {
                // Fyll på namnet i listan
                kontaktLista.Add($"{namn}\t{mobil}");

                // Fyll i rutaAllaKontakter
                rutaAllaKontakter.Text += $"{namn}\t{mobil}\n";

                // Spara ned!
                File.WriteAllLines(filen, kontaktLista);

                //Konvertera till Json
                //1 Skapa ett objekt
                Kontakt objekt = new Kontakt();
                objekt.Namn = namn;
                objekt.Mobil = mobil;
                /*  {
                      Namn = namn,
                      Mobil = mobil
                  };*/
                //2 Skapa Json text

                //3. Spara ned Json i fil
            }
            else
            {
                rutaStatus.Text = "String does NOT contain numbers!";
            }
        }
    }
}