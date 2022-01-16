using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f(x) = {Function(x):F3}");
            Console.ReadKey();
        }

          static double Function(double x)
        {
            return Math.Pow(x,2)+10/Math.Sqrt(Math.Pow(x,2)+1);


        }
    }
}
