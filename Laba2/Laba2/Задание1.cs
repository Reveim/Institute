using System;

namespace Laba2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            fxk();
        }
        static double fxk()
        {
            double sum = new double();
            for (double k = 1; k <= 10; k++)
            {
                for (double x = -10; x <= 10; x++)
                {
                    sum = x / (Math.Sqrt(x) + Math.Pow(Math.E, k));
                    Console.Write(String.Format("{0:0.0000}", sum) + "  ");
                }
                Console.WriteLine();
            }
            return sum;
        }
    }
}
         

