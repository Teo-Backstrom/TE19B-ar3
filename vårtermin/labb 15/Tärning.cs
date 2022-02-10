using System;

namespace labb_15
{
    public class Tärning
    {
        public int Sidor { get; set; }

        public int KastaTärning()
        {
            Random tarning = new Random();
            return tarning.Next(1, Sidor);
        }
    }
}