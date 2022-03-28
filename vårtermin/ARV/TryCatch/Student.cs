using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace TryCatch
{

    public class Student : Person
    {
        private string studieprogram;

        public string Studieprogram
        {
            get
            {
                return studieprogram;
            }
            set
            {
                //Kolal att inmattat studieprogram är: Teknik, It elelr Estet
                // if (value.ToLower() != "teknik" && value.ToLower() != "it" && value.ToLower() != "estet")
                string[] lista = { "teknik", "estet", "it" };
                if (!lista.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Ogiltigt tudieprogram");
                }
                else
                {

                }
                studieprogram = value;
            }


        }
        public Student(string förnamn, string efternamn, string studieprogram) : base(förnamn, efternamn)
        {
            Studieprogram = studieprogram;
        }

        public override string Sammanfattning()
        {
            return null;
        }
    }
}