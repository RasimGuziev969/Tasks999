using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask3
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
            return ((x * x) + 10) / Math.Sqrt((x * x) + 1);
        }
    }
}
