using System.Data;
using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        //"varibaler" för att lagra data(egenskaper)
        public string Namn { get; set; } //Skydda variabeln från ottilåten ändring.
        public int Lön { get; set; }
        public int Timmar { get; set; }

        //Klassmetod
        public int Timlön()
        {
            return Lön / Timmar;
        }

        public void VisaTimlön()
        {
            Console.WriteLine($"{Namn} din timlön är {Lön / Timmar}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            //Lagra uppgifter i ett objekt
            List<PersonInkomst> lista = new List<PersonInkomst>();

            //upprepa tills användaren skriver tomt
            while (true)
            {
                PersonInkomst objekt = new PersonInkomst();

                // Ange namn och lön
                Console.WriteLine("Ange ditt namn (Enter avbryter)");
                objekt.Namn = Console.ReadLine();
                if (objekt.Namn == "")
                {
                    break;
                }

                Console.WriteLine("Ange din månadslön: ");
                objekt.Lön = ReadInt();
                Console.WriteLine("Ange antal timmar: ");
                objekt.Timmar = ReadInt();

                //Lägg in i listan

                lista.Add(objekt);
            }
            int lönToltal = 0;
            int timmarToltal = 0;
            foreach (var item in lista)
            {
                lönToltal += item.Lön;
                timmarToltal += item.Timmar;
                Console.WriteLine($"{item.Namn} din timlön är {item.Timlön()}");
            }

            Console.WriteLine("lön total är: " + lönToltal);
            Console.WriteLine("timmar total är: " + timmarToltal);

            Console.WriteLine("Vilken anställds timlön vill du kolla upp?");
            string person = Console.ReadLine().ToLower();
            int timlön = 0;
            foreach (var item in lista)
            {
                if (item.Namn.ToLower() == person)
                {
                    timlön = item.Lön / item.Timmar;
                }
            }

            Console.WriteLine($"Timlönen för {person} är {timlön}");

        }

        /// <summary>
        /// Metoden för sökert sätt att läsa heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
