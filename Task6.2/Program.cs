using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());

            if ((y >= -2) && (y <= 1.5))
                Console.WriteLine("Принадлежит");
            else
                Console.WriteLine("Не принадлежит");
        }
    }
}
