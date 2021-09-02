using System;

namespace CesarKryptoUtanWpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text som skall krypteras: ");
            string text = Console.ReadLine();

            Console.Write("Ange en nyckel (1-9): ");
            string nyckelString = Console.ReadLine();

            int nyckel = 0;
            while (!int.TryParse(nyckelString, out nyckel))
            {
                Console.WriteLine("Du måste mata in ett tal (1-9). Försök igen: ");
                nyckelString = Console.ReadLine();
            }

            string kryptadText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                int ascii = (int)bokstav;
                Console.WriteLine($"{bokstav} är {ascii}");

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);
                Console.WriteLine($"{bokstav} blir {kryptadBokstav}");

                kryptadText += kryptadBokstav.ToString();
            }

            Console.WriteLine($"Den krypterade texten blir: {kryptadText}");
        }
    }
}
