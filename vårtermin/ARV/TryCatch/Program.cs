using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Förnamn Efternamn lön timmar ");
                string[] input = Console.ReadLine().Split(" ");


                // Kolla att vi fick 4 strings
                if (input.Length == 4)
                {
                    //Lagra i en instans(objekt)
                    Arbetare arbetare = new Arbetare(input[0], input[1], input[2], input[3]);
                    Console.WriteLine(arbetare.Sammanfattning());
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn blank efternam");
                }





            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
