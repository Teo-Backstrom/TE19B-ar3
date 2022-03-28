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
                    //är detta rätt eller ska det stå Filmer istället för Media
                    Media film = new Filmer(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängd.Text);
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
                    //är detta rätt eller ska det stå Media itsället för Böcker
                    Böcker bok = new Böcker(rutaBokTitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
                    Textruta.Items.Add(bok.TillText());
                    samling.Add(bok);

                }
            }

        }
        private void CheckaRadio(object sender, RoutedEventArgs e)
        {
            Textruta.Items.Clear();

            /*
                        if (Alla.IsChecked == true)
                        {
                            Textruta.Items.Clear();

                            foreach (var I in samling)
                            {
                                Textruta.Items.Add(I.TillText());


                            }
                        }

                        if (Bok.IsChecked == true)
                        {
                            Textruta.Items.Clear();
                            foreach (var bok in samling)
                            {
                                Textruta.Items.Add(bok.TillText());

                            }

                        }
                        if (Film.IsChecked == true)
                        {
                            Textruta.Items.Clear();
                            foreach (var film in samling)
                            {
                                Textruta.Items.Add(film.TillText());

                            }

                        }*/

            string typ = ((RadioButton)sender).Name;

            switch (typ)
            {
                case "Alla":

                    foreach (var I in samling)
                    {
                        Textruta.Items.Add(I.TillText());

                    }
                    break;
                case "Bok":
                    foreach (var I in samling)
                    {
                        if (I is Böcker)
                        {
                            Textruta.Items.Add(I.TillText());
                        }

                    }
                    break;
                case "Film":
                    foreach (var I in samling)
                    {
                        if (I is Filmer)
                        {
                            Textruta.Items.Add(I.TillText());
                        }

                    }
                    break;
            }

            //Vilken typ av instans är det?
            //if (samling is Bok)


        }
        private void ClosingWindow(object sender, CancelEventArgs e)
        {
            List<Filmer> filmsamling = new List<Filmer>();
            List<Böcker> boksamling = new List<Böcker>();

            var options = new JsonSerializerOptions { WriteIndented = true };

            foreach (var I in samling)
            {
                if (I is Filmer)
                {
                    Filmer f = I as Filmer;
                    filmsamling.Add(f);
                }

            }
            foreach (var I in samling)
            {
                if (I is Böcker)
                {
                    Böcker b = I as Böcker;
                    boksamling.Add(b);
                }

            }

            string JsonText = JsonSerializer.Serialize(filmsamling, options);
            File.WriteAllText("Samling.json", JsonText);

            JsonText = JsonSerializer.Serialize(boksamling, options);
            File.WriteAllText("Böcker.json", JsonText);




        }

    }
}