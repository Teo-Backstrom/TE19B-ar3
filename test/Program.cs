using System;
using System.IO;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //flagga för att se om man vill lägag in fler böcker
            string flagga = "";

            //listor för att spara objekten
            List<Book> boksammling = new List<Book>();
            List<LimitedEditionBook> limiboksammling = new List<LimitedEditionBook>();

            while (flagga != "n")
            {

                try
                {

                    //sammlar in inforation
                    Console.Write("Enter author: ");
                    string författare = Console.ReadLine();
                    Console.Write("Enter title: ");
                    string titel = Console.ReadLine();
                    Console.Write("Enter ISBN (13 number length): ");
                    string isbn = Console.ReadLine();
                    Console.WriteLine("Special year (xxxx)");
                    string unikÅr = Console.ReadLine();
                    Console.WriteLine("How many special editions: ");
                    string antalUnika = Console.ReadLine();

                    //sparar info i rätt objekt

                    if (unikÅr != "" || antalUnika != "")
                    {
                        LimitedEditionBook book = new LimitedEditionBook(författare, titel, isbn, unikÅr, antalUnika);
                        limiboksammling.Add(book);


                    }
                    else
                    {
                        Book book = new Book(författare, titel, isbn);
                        boksammling.Add(book);

                    }


                }
                catch (ArgumentException e)
                {
                    //skriver ut fel
                    Console.WriteLine(e.Message);
                    //flaggar att det är fel
                }



                //frågar om hen vill registera fler böcker
                Console.WriteLine("Do want to register one more book (y/n): ");
                flagga = Console.ReadLine().ToLower();
            }

            //skriver ut hur många böcker som registrerades
            Console.WriteLine("Total books: " + boksammling.Count);
            Console.WriteLine("Total limitedbooks: " + limiboksammling.Count);

            Console.WriteLine("Böcker som lades till var: ");
            foreach (var item in boksammling)
            {
                item.Summary();
            }
            foreach (var item in limiboksammling)
            {
                item.Summary();
            }


        }
    }
}
