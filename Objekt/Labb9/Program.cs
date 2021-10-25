using System.Net;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;


namespace Labb9
{
    class NamnAdress
    {
        public string Namn = "";
        public string Efternamn = "";
        public string Gatuadress = "";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<NamnAdress> lista = new List<NamnAdress>();



            Console.WriteLine("Program för att spara namn och adress");

            NamnAdress objekt = new NamnAdress();

            string JsonText = File.ReadAllText("filmer.json");
            // Ange namn och och adress
            Console.WriteLine("Ange ditt förnamn");
            objekt.Namn = Console.ReadLine();
            Console.WriteLine("Ange ditt efternamn");
            objekt.Efternamn = Console.ReadLine();
            Console.WriteLine("Ange din adress");
            objekt.Gatuadress = Console.ReadLine();
            //Lägg in i listan
            lista.Add(objekt);
            JsonText += "[" + JsonConvert.SerializeObject(objekt, Formatting.Indented) + "," + "]";
            File.WriteAllText("filmer.json", JsonText);
        }


    }
}
