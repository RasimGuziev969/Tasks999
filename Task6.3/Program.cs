using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._3
{
    class Program
    {
        public static void convert(string chess, out int x, out int y)
        {
            x = chess[0] - 'a' + 1;
            y = chess[1] - '0';
        }

        public static bool check_l(string start, string end)
        {
            int xs, ys, xe, ye;
            convert(start, out xs, out ys);
            convert(end, out xe, out ye);

            if ((xs == xe) || (ys == ye))
                return true;
            return false;
        }

        public static bool check_k(string start, string end)
        {
            int xs, ys, xe, ye;
            convert(start, out xs, out ys);
            convert(end, out xe, out ye);
            if ((Math.Abs(xs - xe) <= 1) || (Math.Abs(ys - ye) <= 1))
                return true;
            return false;
        }

        public static bool step(string white_s, string white_e, string black)
        {
        
            if (check_l(white_s, white_e))
                if (!check_k(white_e, black))
                    return true;
            return false;
        }

        public static void Main(string[] args)
        {
            string white_start, white_end, black;
            white_start = Console.ReadLine();
            
            black = Console.ReadLine();

            if (white_start == black)
            {
                Console.WriteLine("Введена одна и та же координата");
                return;
            }

            if (check_k(white_start, black))
            {
                Console.WriteLine("Ладья под боем короля");
                return;
            }

            white_end = Console.ReadLine();

            Console.WriteLine(step(white_start, white_end, black));

        }
    }
}
