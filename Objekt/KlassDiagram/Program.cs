using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace KlassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personinkomst> listaPerson = new List<Personinkomst>();

            Console.WriteLine("Räkna ut lönekostnad");
            //loopa ett antal gånger
            while (true)
            {
                //Skapa objektet person från klassen Personinkomst
                Personinkomst person = new Personinkomst();
                //ange namn
                Console.Write("Vad heter den anställde: ");
                person.namn = Console.ReadLine();

                //Avslutar om namn ä rtomt
                if (person.namn == "")
                {
                    break;
                }

                //Ange timlön
                Console.Write("Den anställdes timlön: ");
                person.timlön = ReadInt();

                //Ange timmar
                Console.Write("Den anställdes arbetstid: ");
                person.timmar = ReadInt();

                listaPerson.Add(person);

            }
            // Spara ned som hson
            string JsonText = JsonConvert.SerializeObject(listaPerson, Formatting.Indented);
            File.WriteAllText("personerinkomst.json", JsonText);


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
