using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_____4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Funct(2, 3, 5) + Funct(5, 7, 12) + Funct(11, 13, 24);
            Console.WriteLine($" {x:F3}");

            Console.ReadKey();
        }
        static double Funct(double n1, double n2, double n3)
        {
            return (Math.Sin(n1) + Math.Sin(n2)) / n3;
        }
    }
}
