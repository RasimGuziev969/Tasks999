using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            var y = double.Parse(Console.ReadLine());

            static bool Check(double x, double y)
            {
                return (y > -2 && y < 1.5);
            }
        }
    }
}
