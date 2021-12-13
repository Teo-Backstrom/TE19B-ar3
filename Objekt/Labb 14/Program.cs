using System;

namespace Labb_14
{
    class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int AntalSidor { get; set; }

        public void SkrivUt()
        {
            Console.WriteLine($"Titel: {Titel}\nFörfattare: {Författare}\nAntal Sidor: {AntalSidor}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bok boken = new Bok();
            Console.WriteLine("Vad heter boken");
            boken.Titel = Console.ReadLine();

            Console.WriteLine("Vem är författaren");
            boken.Författare = Console.ReadLine();

            Console.WriteLine("Hur många sidor är boken");
            boken.AntalSidor = ReadInt();

            boken.SkrivUt();
        }
        /// <summary>
        /// Metoden för säkert sätt att läsa heltal
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
