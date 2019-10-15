using System;

namespace Laba2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            double x;
            Console.WriteLine("Введи x");
            x = Convert.ToDouble(Console.ReadLine());
            sigma(x);
        }
        static double sigma(double x)
        {
            double sum= new double();
            for (int k = 0; k <= 10; k++)
            {
                sum = sum + x / (Math.Sqrt(x) + Math.Pow(Math.E, k));
                Console.Write(String.Format("{0:0.0000}", sum) + "  ");

            }
            Console.WriteLine();
            Console.WriteLine("Конечная сумма");
            Console.Write(String.Format("{0:0.0000}", sum) + "  ");
            return sum;
        }
    }
   
}
