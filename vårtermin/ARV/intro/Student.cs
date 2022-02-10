using System;

namespace intro
{
    public class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }


        //En metod som skriver över bas classens metod
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");

        }
    }
}