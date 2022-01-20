using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace andra_efter_lov
{
    public class Avtal
    {
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kosdtnad { get; set; }
        public int Tidsram { get; set; }
        public bool Ledig { get; set; }
        public string PersonNr { get; set; }

        private IDictionary<string, int> bilar = new Dictionary<string, int>(){
            {"ABC123", 500},
            {"DEF456", 400},
            {"GHI789", 199}
        };

        public int RäknaKostnad()
        {
            int extra = 0;
            //@todo inte krascha om regnr inte finns
            int kostnad = bilar[RegNr] * Tidsram;

            if (Km > 100)
            {
                extra = 2 * Km - 100;
            }
            Kosdtnad = kostnad + extra;
            return Kosdtnad;
        }

        public string InlämningsDatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd/MM-yy");
        }

        public bool DoesRegExcist()
        {
            if (bilar.ContainsKey(RegNr))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}