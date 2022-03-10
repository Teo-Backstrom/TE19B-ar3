using System.ComponentModel;
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
using System.Text.Json;
using System.IO;

namespace Labb19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // if(object is Class)

        List<Media> samling = new List<Media>();

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
                    samling.Add(film);
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
                    samling.Add(bok);

                }
            }

        }
        private void CheckaRadio(object sender, RoutedEventArgs e)
        {

            if (Alla.IsChecked == true)
            {
                Textruta.Items.Clear();

                foreach (var I in samling)
                {
                    Textruta.Items.Add(I.TillText());


                }
            }

            else if (Bok.IsChecked == true)
            {
                Textruta.Items.Clear();
                foreach (var bok in samling)
                {
                    Textruta.Items.Add(bok.TillText());

                }

            }
            else if (Film.IsChecked == true)
            {
                Textruta.Items.Clear();
                foreach (var film in samling)
                {
                    Textruta.Items.Add(film.TillText());

                }

            }


        }
        private void ClosingWindow(object sender, CancelEventArgs e)
        {/*
            var options = new JsonSerializerOptions { WriteIndented = true };

            string JsonText = JsonSerializer.Serialize(samling, options);
            File.WriteAllText("Filmer.json", JsonText);

            JsonText = JsonSerializer.Serialize(boksammling, options);
            File.WriteAllText("Böcker.json", JsonText);



       */
        }

    }
}