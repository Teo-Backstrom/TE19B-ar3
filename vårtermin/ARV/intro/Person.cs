using System;

namespace intro
{
    /// <summary>
    /// abdklassen
    /// </summary>
    public class Person
    {
        public string Namn { get; set; }
        public string Mobil { get; set; }

        //ctor kör vid new
        public Person(string namn, string mobil)
        {
            Namn = namn;
            Mobil = mobil;
        }

        // En virtual metod kan man skriva över
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }
}