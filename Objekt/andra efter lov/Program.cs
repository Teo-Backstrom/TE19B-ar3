using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace andra_efter_lov
{

    class Program
    {
        static List<Avtal> listaAvtal = new List<Avtal>();

        static void Main(string[] args)
        {
            string filen = "Avtalen.json";
            if (File.Exists(filen))
            {
                listaAvtal = File.ReadAllLines(filen).ToList();
            }
            else
            {
                Console.WriteLine("Filen finns inte");
            }

            string svar = "j";
            while (svar == "j")
            {


                Avtal avtal1 = new Avtal();
                Console.WriteLine("Välkommen till biluthyrningen");
                Console.WriteLine("Ange personNr: ");
                avtal1.PersonNr = Console.ReadLine();
                Console.WriteLine("Ange RegNr: ");
                avtal1.RegNr = Console.ReadLine();
                while (!avtal1.DoesRegExcist())
                {
                    Console.WriteLine("Ange RegNr: ");
                    avtal1.RegNr = Console.ReadLine();
                }
                Console.WriteLine("Ange antal Km: ");
                avtal1.Km = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange Tidsram: ");
                avtal1.Tidsram = int.Parse(Console.ReadLine());

                avtal1.Datum = DateTime.Now;

                Console.WriteLine("Totala hyran blir " + avtal1.RäknaKostnad());
                Console.WriteLine("Inlämningsdatum: " + avtal1.InlämningsDatum());
                listaAvtal.Add(avtal1);

                Console.WriteLine("Vill du mata in en till?(j/n)");
                svar = Console.ReadLine().ToLower();
            }

            string JsonText = JsonConvert.SerializeObject(listaAvtal, Formatting.Indented);
            File.WriteAllText(filen, JsonText);

        }
    }
}
