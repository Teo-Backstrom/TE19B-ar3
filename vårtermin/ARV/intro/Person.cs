using System;

namespace intro
{
    public class Person
    {
        public string Namn { get; set; }
        public string Mobil { get; set; }

        // En virtual metod kan man skriva över
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }
}