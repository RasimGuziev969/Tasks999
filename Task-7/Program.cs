using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        public static float f(float x)
        {
            if (x > 2)
                return 2;
            if ((x <= 2) && (x >= -2))
                return x;
            if (x < -2)
                return -2;
            return -999;
        }
        public static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
        }
    }
}
