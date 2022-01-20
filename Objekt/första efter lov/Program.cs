using System;

namespace första_efter_lov
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public double getVolume()
        {
            return Length * Breadth * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Box box = new Box();

            box.Length = 10;
            box.Breadth = 15;
            box.Height = 5;

            Console.WriteLine(box.Length + " " + box.Height + " " + box.Breadth);
            Console.WriteLine(box.getVolume());
        }
    }
}
