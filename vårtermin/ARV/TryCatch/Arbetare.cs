using System.Diagnostics.Tracing;
using System;

namespace TryCatch
{
    public class Arbetare : Person
    {
        private int lön;
        private int antalTimmar;

        public int Lön
        {
            get
            {
                return lön;
            }
            set
            {
                if (value >= 0 && value <= 20000)
                    lön = value;
                else
                    throw new ArgumentException("lön måste vara mellan 0 och 20000");
            }
        }

        public int AntalTimmar
        {
            get
            {
                return antalTimmar;
            }
            //Kolla att användaren mater in rimlinga data
            set
            {
                if (value < 60)
                    antalTimmar = value;
                else
                    throw new ArgumentException("du kan inte arbeta mer än 59.999999timmar");
            }
        }

        public Arbetare(string förnamn, string efternam, string lön, string antalTimmar) : base(förnamn, efternam)
        {
            int resultat = 0;

            if (!int.TryParse(lön, out resultat))
            {
                throw new ArgumentException("Lön måste var ett helttal");
            }
            else
            {
                Lön = resultat;
            }
            if (!int.TryParse(antalTimmar, out resultat))
            {
                throw new ArgumentException("Lön måste var ett helttal");
            }
            else
            {
                AntalTimmar = resultat;
            }
        }

        private float RäknaUtTimlön()
        {
            return lön / antalTimmar;
        }

        public override string Sammanfattning()
        {
            return "Du tjänade " + lön + " och hade " + RäknaUtTimlön() + " som timlön";
        }
    }
}