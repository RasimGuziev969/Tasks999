using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            a = a.Replace("А", "A");
            a = a.Replace("Б", "B");
            a = a.Replace("В", "V");
            a = a.Replace("Г", "G");
            a = a.Replace("Д", "D");
            a = a.Replace("Е", "E");
            a = a.Replace("Ё", "E");
            a = a.Replace("Ж", "ZH");
            a = a.Replace("З", "Z");
            a = a.Replace("И", "I");
            a = a.Replace("К", "K");
            a = a.Replace("Л", "L");
            a = a.Replace("М", "M");
            a = a.Replace("Н", "N");
            a = a.Replace("О", "O");
            a = a.Replace("П", "P");
            a = a.Replace("Р", "R");
            a = a.Replace("С", "S");
            a = a.Replace("Т", "T");
            a = a.Replace("У", "U");
            a = a.Replace("Ф", "F");
            a = a.Replace("Х", "KH");
            a = a.Replace("Ц", "TS");
            a = a.Replace("Ч", "CH");
            a = a.Replace("Ш", "SH");
            a = a.Replace("Щ", "SHCH");
            a = a.Replace("Ъ", "IE");
            a = a.Replace("Ы", "Y");
            a = a.Replace("Ь", "");
            a = a.Replace("Э", "E");
            a = a.Replace("Ю", "IU");
            a = a.Replace("Я", "IA");


            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
