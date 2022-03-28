using System;

namespace matte
{
    class Program
    {
        static void Main(string[] args)
        {
            int skjortor = 4;
            //2 par blå jeans
            int byxor = 4;
            int strumpor = 4;
            int skor = 3;

            Console.WriteLine(skjortor * byxor * strumpor * skor);
            Console.WriteLine((skjortor * strumpor * (skor - 1) * byxor) + (skjortor * (byxor - 1) * strumpor));

            Console.WriteLine("sista uppgift");
            Console.WriteLine((skjortor * (byxor - 1) * strumpor * (skor - 1)) + (strumpor * (skor - 1)) + (skjortor * (byxor - 1)) + 1);



        }
    }
}
