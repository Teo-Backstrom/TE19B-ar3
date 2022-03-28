using System;

namespace test
{
    public class LimitedEditionBook : Book
    {

        public string unikaÅr;
        public string antalUnika;

        //tar in information och kolla om formatet är korrekt
        public string UnikaÅr
        {
            get
            {
                return unikaÅr;
            }
            set
            {
                if (value.Length != 4)
                    throw new ArgumentException("Year is not in right format try xxxx");
                else
                    unikaÅr = value;
            }
        }

        //Antal exemplar ett tal mellan 10 och 500

        public string AntalUnika
        {
            get
            {
                return antalUnika;
            }
            set
            {
                int resultat = 0;

                if (!int.TryParse(value, out resultat))
                {
                    throw new ArgumentException("The amount of limited books must be in numbers");
                }
                else if (resultat > 10 && resultat < 500)
                {
                    antalUnika = resultat.ToString();
                }
                else
                {
                    throw new ArgumentException("The amount of limited books is to high or low");
                }

            }
        }

        //tar in infortmaion
        public LimitedEditionBook(string författare, string titel, string isbn, string unikÅr, string antalUnika) : base(författare, titel, isbn)
        {
            UnikaÅr = unikÅr;
            AntalUnika = antalUnika;

        }

        //skriver en sammanfattnign av boken
        public override void Summary()
        {
            Console.WriteLine($"Title : {titel} Auther: {författare} ISBN: {isbn} Limitedyear {unikaÅr} Amount of limited: {antalUnika}");
        }
    }
}