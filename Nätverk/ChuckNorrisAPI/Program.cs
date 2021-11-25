using System;
using RestSharp;
using System.Text.Json;

namespace ChuckNorrisAPI
{
    class Joke
    {
        public string icon_url { get; set; }
        public string value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chuck Norris skämt");

            // Hämta ett skämt från api.chucknorris.io
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            //KOLLA PÅ SVARET
            //   Console.WriteLine(response.Content);

            //Skapa ny objekt
            Joke skämtet = new Joke();

            //Avkoda json svaret
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);

            Console.WriteLine(skämtet.value);


        }
    }
}
