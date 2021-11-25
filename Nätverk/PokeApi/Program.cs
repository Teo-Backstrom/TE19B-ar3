using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace PokeApi
{
    class Pokemon
    {
        public string name { get; set; }
    }

    class Pokemons
    {
        public int count { get; set; }
        public List<Pokemon> results { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta Pokemon info");

            //hämta ett skämt
            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("pokemon", DataFormat.Json);
            var response = client.Get(request);

            //kollar på svaret
            //  Console.WriteLine(response.Content);
            //Skapa ny objekt
            Pokemons lista = new Pokemons();

            //Avkoda json svaret
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);

            //skriv ut alla pokemons

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
