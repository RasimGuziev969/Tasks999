using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentIP : Student
    {
        public int Exam;
        public double GPA;

        public StudentIP(string name, string surname, int number, int exam, double gpa) : base(name, surname, number)
        {
            Exam = exam;
            GPA = gpa;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            info[1] += $"\nБалл ЕГЭ: {Exam}. Средний балл в БРС: {GPA}";
            return info;
        }
    }
}
