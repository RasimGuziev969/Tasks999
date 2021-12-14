using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task____2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            double a,b,c,p,p2,s;
            a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            p = a + b + c;
            p2 = (a + b + c)/2;
            s = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            Console.WriteLine($" a: {a}, b: {b}, c: {c} ");
            Console.WriteLine($"Периметр: {p}, Площадь: {s} ");
            Console.ReadKey();

        }
    }
}
