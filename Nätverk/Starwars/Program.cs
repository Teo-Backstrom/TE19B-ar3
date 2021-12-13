using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace Starwars
{
    class Karaktär
    {
        public string name { get; set; }
    }

    class Karaktärer
    {
        public List<Karaktär> results { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta Starwars info");

            //Hämta info
            string url = "https://swapi.dev/api/";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            //kollar på svaret
            //  Console.WriteLine(response.Content);
            //Skapa ny objekt
            Karaktärer lista = new Karaktärer();

            //Avkoda json svaret
            lista = JsonSerializer.Deserialize<Karaktärer>(response.Content);

            //skriv ut alla Karaktärer

            if (lista != null)
            {
                foreach (var item in lista.results)
                {
                    Console.WriteLine(item.name);
                }
            }



        }
    }
}
