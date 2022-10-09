using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentEx : Student
    {
        public string Workplace;
        public string Job;

        public StudentEx(string name, string surname, int number, string workplace, string job) : base(name, surname, number)
        {
            Workplace = workplace;
            Job = job;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            info[1] += $"\nМесто работы: {Workplace}. Должность: {Job}";
            return info;
        }
    }
}
