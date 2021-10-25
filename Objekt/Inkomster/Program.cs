using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
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

                Console.WriteLine("Ange din månadslön");
                objekt.Lön = ReadInt();

                //Lägg in i listan

                lista.Add(objekt);
            }


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
