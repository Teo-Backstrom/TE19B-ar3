using System;

namespace labb_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Tärning tärning = new Tärning();

            tärning.Sidor = 6;

            Console.WriteLine(tärning.KastaTärning());
        }
    }
}
