using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = 0;

            for (var i = 1; i <= 100000000; i++)

            {

                s += Function(i);

                if (s >= 100000000)

                    s %= 100000000;

            }

            Console.WriteLine(s);

            Console.ReadKey();

        }

        static int Function(int n)

        {

            if ((n == 1) || (n == 3))

                return n;

            else if (n % 2 == 0)

                return Function(n / 2);

            else if ((n - 1) % 4 == 0)

                return 2 * Function((n - 1) / 2 + 1) - Function((n - 1) / 4);

            else if ((n - 3) % 4 == 0)

                return 3 * Function((n - 3) / 2 + 1) - 2 * Function((n - 3) / 4);

            return n;

        }
    }
}
