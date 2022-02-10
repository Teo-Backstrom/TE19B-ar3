using System;

namespace intro
{
    public class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämnen { get; set; }

        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Antällningsår: {Anställningsår}, Ämnen: {Ämnen}");
        }
    }
}