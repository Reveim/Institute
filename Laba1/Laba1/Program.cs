using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z,e,p,l;
            //Console.WriteLine("Введи x");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введи y");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введи z");
            //z = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введи p");
            //p = Convert.ToDouble(Console.ReadLine());
            x = 182.5;
            y = 18.225;
            z = -0.03298;
            e = Math.Exp(1);
            double f = fd(x, y, z);
            Console.WriteLine(f);
            



            //if (x > Math.Abs(p)) l = (2 * Math.Pow(e, x)); 
            //if (3 < x)
            //{
            //  if (x<Math.Abs(p)) l = Math.Abs(Math.Pow(e, x) - p);

            //}
            //if (x == Math.Abs(p)) l = Math.Pow(Math.Pow(e, x) - p, 2);

        }
        static double fd (double x, double y, double z)
        {
            double f;
            f = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1.0 / 3.0)) + (y - x) * ((Math.Cos(y) - (z / (y - x))) / (1 + Math.Pow(y - x, 2)));
            return f;
           
        }
         
    }
}
