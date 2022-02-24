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
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace _19b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Filmer> filmsammling = new List<Filmer>();
        public List<Böcker> boksammling = new List<Böcker>();

        public object JsonConvert { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            int heltal;
            if (int.TryParse(rutaLängd.Text, out heltal))
            {
                if (heltal > 0 && rutaRegissör.Text != "" && rutaFilmtitel.Text != "")
                {
                    Filmer film = new Filmer(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängd.Text);
                    Textruta.Items.Add(film.TillText());
                    filmsammling.Add(film);
                }
            }


        }
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            int heltal;
            if (int.TryParse(rutaLängd.Text, out heltal))
            {
                if (heltal > 0 && rutaRegissör.Text != "" && rutaFilmtitel.Text != "")
                {
                    Böcker bok = new Böcker(rutaBokTitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
                    Textruta.Items.Add(bok.TillText());
                    boksammling.Add(bok);

                }
            }

        }
        private void CheckaRadio(object sender, RoutedEventArgs e)
        {
            if (Alla.IsChecked == true)
            {
                Textruta.Items.Clear();
                foreach (var film in filmsammling)
                {
                    Textruta.Items.Add(film.TillText());

                }
                foreach (var bok in boksammling)
                {
                    Textruta.Items.Add(bok.TillText());

                }
            }

            else if (Bok.IsChecked == true)
            {
                Textruta.Items.Clear();
                foreach (var bok in boksammling)
                {
                    Textruta.Items.Add(bok.TillText());

                }

            }
            else if (Film.IsChecked == true)
            {
                Textruta.Items.Clear();
                foreach (var film in filmsammling)
                {
                    Textruta.Items.Add(film.TillText());

                }

            }


        }
        private void ClosingWindow(object sender, CancelEventArgs e)
        {

            // Spara ned som json med formatting
            string JsonText = JsonConvert.SerializeObject(filmsammling, Formatting.Indented);
            File.WriteAllText("Filmer.json", JsonText);





        }

    }
}
