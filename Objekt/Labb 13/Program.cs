using System;
using System.Text.RegularExpressions;

namespace Labb_13
{
    class Person
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public string DateTime { get; set; }
        public double Längd { get; set; }
        public double Vikt { get; set; }

        public void FullNamn()
        {
            Console.WriteLine(Förnamn + " " + Efternamn);
        }

        public bool Myndig()
        {

            string[] datum = DateTime.Split("-");
            double allDagar = (2021 - int.Parse(datum[0])) * 365.25 + int.Parse(datum[1]) * 30 + int.Parse(datum[2]);
            if (allDagar >= 6570)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double BMI()
        {
            return Vikt / Math.Pow(Längd, 2.00);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("förnamn");
            person.Förnamn = Console.ReadLine();
            Console.WriteLine("efternamn");
            person.Efternamn = Console.ReadLine();
            Console.WriteLine("Hur lång är du (m)");
            person.Längd = ReadDouble();
            Console.WriteLine("Vad väger du");
            person.Vikt = ReadDouble();

            Regex regex = new Regex(@"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$");
            Console.WriteLine("Födelsedatum (format: xxxx-xx-xx  ex. 2003-04-23)");

            person.DateTime = Console.ReadLine();
            while (!regex.IsMatch(person.DateTime))
            {
                Console.WriteLine("try again");
                person.DateTime = Console.ReadLine();
            }
            person.FullNamn();

            if (person.Myndig())
            {
                Console.WriteLine("personen är myndig");
            }
            else
            {
                Console.WriteLine("Personen är inte myndig");
            }

            Console.WriteLine($"Hens BMI är {person.BMI()}");
        }
        /// <summary>
        /// Metoden för säkert sätt att läsa heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        static double ReadDouble()
        {
            double heltal;
            while (!double.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
