using System;
using System.Collections.Generic;

namespace Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en array
            string[] städer = { "stockholm", "berlin", "Paris" };
            string[] frukter = new string[3];
            frukter[0] = "Äpple";
            frukter[1] = "Apelsin";
            frukter[2] = "Banan";

            //Skapa en lista av namn
            List<string> namnen = new List<string>() { "Miriam", "Teo", "Axel" };

            // Skapa en till lista tom
            List<string> bären = new List<string>();

            bären.Add("Blåbär");
            bären.Add("Lingon");
            bären.Add("Hallon");
            bären.Add("Björnbär");
            bären.Add("Hjortron");
            bären.Add("Smultron");

            //Skriv ut alla frukter

            for (int i = 0; i < frukter.Length; i++)
            {
                Console.WriteLine(frukter[i]);
            }
            //en annan loop
            foreach (var frukt in frukter)
            {
                Console.WriteLine(frukt);
            }

            for (int i = 0; i < bären.Count; i++)
            {
                Console.WriteLine(bären[i]);
            }
            //en annan loop
            foreach (var bär in bären)
            {
                Console.WriteLine(bär);
            }

            //Om vi ska hitta en stad
            foreach (var stad in städer)
            {
                if (stad == "berlin")
                {
                    Console.WriteLine("Hittade berlin");
                }
            }

            if (bären.Contains("Blåbär"))
            {
                Console.WriteLine("Hittade Blåbär");
            }

            //  bären.Remove("Hallon");
            //  bären.RemoveAt(1);
            bären.Insert(3, "rönnbär");

            foreach (var bär in bären)
            {
                Console.WriteLine(bär);
            }
        }
    }
}
