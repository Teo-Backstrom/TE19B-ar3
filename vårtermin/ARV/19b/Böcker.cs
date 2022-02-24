using System;

namespace _19b
{
    public class Böcker : Media
    {
        public string Författare { get; set; }
        public string AntalSidor { get; set; }

        public override string TillText()
        {
            return $"Titel: {Titel} Författare: {Författare} AntalSidor: {AntalSidor}";
        }

        public Böcker(string t, string författare, string antalsidor) : base(t)
        {
            Författare = författare;
            AntalSidor = antalsidor;
        }
    }
}