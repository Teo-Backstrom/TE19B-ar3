using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace apod
{
    class Nasa
    {
        public string url { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta APOD info");

            //Hämta info
            string url = "https://api.nasa.gov/planetary/";
            var client = new RestClient(url);
            var request = new RestRequest("apod?api_key=L2ANYiOvaaLITdjcwvObehBWRJZNNVfOAl5WcS94", DataFormat.Json);
            var response = client.Get(request);

            //Skapa ny objekt
            Nasa bild = new Nasa();

            //kollar på svaret
            //  Console.WriteLine(response.Content);

            bild = JsonSerializer.Deserialize<Nasa>(response.Content);

            Console.WriteLine(bild.url);



        }
    }
}
