using System;

namespace intro
{
    /// <summary>
    /// utökar från person
    /// </summary>
    public class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        public Student(string n, string m, string årskurs, string program) : base(n, m)
        {
            Årskurs = årskurs;
            Program = program;
        }


        //En metod som skriver över bas classens metod
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");

        }
    }
}