using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentSponsored : Student
    {
        public string Sponsor;
        public int Price;

        public StudentSponsored(string name, string surname, int number, string sponsor, int price) : base(name, surname, number)
        {
            Sponsor = sponsor;
            Price = price;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            info[1] += $"\nЦелевое предприятие: {Sponsor}. Стоимость обучения: {Price}";
            return info;
        }
    }
}
