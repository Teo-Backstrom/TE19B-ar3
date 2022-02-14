using System;

namespace intro
{
    public class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämnen { get; set; }

        public Lärare(string n, string m, string anställningsår, string ämnen) : base(n, m)
        {
            Anställningsår = anställningsår;
            Ämnen = ämnen;
        }
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Antällningsår: {Anställningsår}, Ämnen: {Ämnen}");
        }
    }
}