using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    public class Program
    {
        public static bool check(int k, int m, int n)
        {
            if((k % 11 == 0) && (n % 11 != 0) && (m % 11 != 0));
                return true;
            if ((k % 11 != 0) && (n % 11 == 0) && (m % 11 != 0))
                return true;
            if ((k % 11 != 0) && (n % 11 != 0) && (m % 11 == 0))
                return true;
            return false;
        }

        public static void Main(string[] args)
        {
            int k, m, n;
            k = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(check(k, m, n));
        }
    }
}
