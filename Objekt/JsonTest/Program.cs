using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonTest
{
    class Film
    {
        public string Titel;
        public string Årtal;
        public string Regissör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapa JSON-objekt");

            Film avatar = new Film()
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron"
            };
            Film legend = new Film()
            {
                Titel = "I Am Legend",
                Årtal = "2008",
                Regissör = "Francis Lawrence"
            };
            Film interstellar = new Film()
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Chrisopher Nolan"
            };

            //Skriv ut lite Json
            string JsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            JsonText += ",\n" + JsonConvert.SerializeObject(legend, Formatting.Indented);
            JsonText += ",\n" + JsonConvert.SerializeObject(interstellar, Formatting.Indented);
            Console.WriteLine(JsonText);

            File.WriteAllText("filmer.json", JsonText);

        }
    }
}
