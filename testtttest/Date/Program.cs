using System.Xml;
using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime idag = DateTime.Now;
            Console.WriteLine($"Dagens datum är {idag}");
            Console.WriteLine($"Dagens månad är {idag.Month}");
            Console.WriteLine($"Vi är idag {idag.Day}");
            Console.WriteLine($"Vi är idag {idag.Hour}:{idag.Minute}");


            //Formatera datum
            Console.WriteLine($"Dagens datum är {idag.ToString("dddd")}");
            Console.WriteLine($"Dagens tid är {idag.ToString("hh:mm")}");

            //om 40 dagar är datumet
            DateTime deadline = idag.AddDays(40);

            Console.WriteLine(deadline);
            Console.WriteLine($"Arbetet skall vara klart {deadline.ToString("dddd dd/MM-yy")}");

            //Be användare om födelsedatum
            Console.WriteLine("När är du född(yyyy-mm-dd)");
            DateTime födelsedatum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(födelsedatum);

            //berätta hur gammal användaren är

            Console.WriteLine(idag.CompareTo(födelsedatum));

            Console.WriteLine($"Din ålder är {((int)Math.Floor(idag.Subtract(födelsedatum).Days / 365.25))}");



        }



    }
}
