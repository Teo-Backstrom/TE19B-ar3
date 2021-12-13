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
using RestSharp;
using System.Text.Json;

namespace APOD_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        class Nasa
        {
            public string url { get; set; }
        }
        public MainWindow()
        {

            InitializeComponent();
            string url = "https://api.nasa.gov/planetary/";
            var client = new RestClient(url);
            var request = new RestRequest("apod?api_key=L2ANYiOvaaLITdjcwvObehBWRJZNNVfOAl5WcS94", RestSharp.DataFormat.Json);
            var response = client.Get(request);

            //Skapa ny objekt
            // Nasa bild = new Nasa(); Samma som rad 47

            //kollar på svaret
            //  Console.WriteLine(response.Content);

            Nasa bild = JsonSerializer.Deserialize<Nasa>(response.Content); // början samma som rad 42

            BildPlats.Source = new BitmapImage(new Uri(bild.url));

            /*
            //   Uri resourceUri = new Uri(bild.url, UriKind.Absolute);
            //  BildPlats.Source = new BitmapImage(resourceUri);
            var image = new Image();
            var fullFilePath = @"https://apod.nasa.gov/apod/image/2111/LLPegasi_HubbleLodge_960.jpg";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            BildPlats.Source = bitmap;
            //  wrapPanel1.Children.Add(image);

            */



        }
    }
}
