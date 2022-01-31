using System;

namespace labb_14
{
    public class Böcker
    {
        private string Titel { get; set; }

        private string Författare { get; set; }
        private int AntalSidor { get; set; }

        public Böcker(string _titel, string _författare, int _antalSidor)
        {
            Titel = _titel;
            Författare = _författare;
            AntalSidor = _antalSidor;
        }

        public void SkrivUt()
        {
            Console.WriteLine($"Titel: {Titel}\nFörfattare: {Författare}\nAntal sidor: {AntalSidor}");
        }
    }
}