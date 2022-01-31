using System.Dynamic;
using System;

namespace labb_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heter");
            string titel = Console.ReadLine();
            Console.WriteLine("Författare");
            string författare = Console.ReadLine();
            Console.WriteLine("Heter");
            int antalSidor = int.Parse(Console.ReadLine());

            Böcker bok = new Böcker(titel, författare, antalSidor);


            bok.SkrivUt();
        }
    }
}
