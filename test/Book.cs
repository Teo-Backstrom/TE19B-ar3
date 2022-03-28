using System;

namespace test
{
    public class Book
    {

        public string titel;
        public string författare;
        public string isbn;

        //sprar titel och ser att den inte är tom
        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Title cant be emty");
                }
                else
                {
                    titel = value;
                }
            }


        }

        //sparar författare och ser att den inte är tom

        public string Författare
        {
            get
            {
                return författare;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("auther cant be emty");
                }
                else
                {
                    författare = value;
                }
            }
        }

        //kollar att isbn är 13 tecken långt
        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentException("isbn måste vara 13 nummer långt");
                }
                else
                {
                    isbn = value;
                }
            }
        }


        //tar in information
        public Book(string författare, string titel, string isbn)
        {
            Författare = författare;
            Titel = titel;
            ISBN = isbn;
        }

        //skriver en sammanfattnign av boken
        public virtual void Summary()
        {
            Console.WriteLine($"Title : {titel} Auther: {författare} ISBN: {isbn}");
        }


    }
}