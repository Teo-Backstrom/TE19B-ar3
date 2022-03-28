using System;

namespace TryCatch
{
    public class Person
    {

        private string förnamn;
        private string efternamn;
        public string Förnamn
        {
            get
            {
                return förnamn;
            }
            set
            {
                //Börjar det med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Förnamn måste börja med en versal");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Förnamn måste vara minst 4 bokstäver");
                }
                else
                {
                    förnamn = value;
                }
            }
        }
        public string Efternamn
        {
            get
            {
                return efternamn;
            }
            set
            {
                //Börjar det med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Efternamn måste börja med en versal");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Efternamn måste vara minst 3 bokstäver");
                }
                else
                {
                    efternamn = value;
                }
            }
        }

        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;

        }

        public virtual string Sammanfattning()
        {
            return null;
        }
    }
}