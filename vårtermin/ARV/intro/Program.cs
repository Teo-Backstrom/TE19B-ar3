using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arv: registera perosner på skolan");

            /* while (true)
            {
                //Skapa en instans (objekt)
                Person person = new Person();

                Console.WriteLine("Vaf heter du?");
                person.Namn = Console.ReadLine();
                Console.WriteLine("Vaf har du för mobilnr?");
                person.Mobil = Console.ReadLine();

                Console.WriteLine("Mata in en till? (j/n)");

                if (Console.ReadLine().ToLower() != "j")
                    break;


            } */
            while (true)
            {
                //Skapa en instans (objekt)
                Student student = new Student();

                Console.WriteLine("Vaf heter du?");
                student.Namn = Console.ReadLine();
                Console.WriteLine("Vaf har du för mobilnr?");
                student.Mobil = Console.ReadLine();
                Console.WriteLine("Vaf har du för Årskurs?");
                student.Årskurs = Console.ReadLine();
                Console.WriteLine("Vaf har du för Program?");
                student.Program = Console.ReadLine();

                student.VisaInfo();


                Console.WriteLine("Mata in en till? (j/n)");

                if (Console.ReadLine().ToLower() != "j")
                    break;


            }
        }
    }
}
