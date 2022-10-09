using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public enum StudyType
    {
        Bachelor,
        Master,
        Specialist
    }

    public class Student
    {
        public string Name;
        public string Surname;
        public readonly int Number;

        public int Group;
        public string Institute;
        public StudyType Type;

        public Student(string name, string surname, int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = ToString();

            string type;
            if (Type == StudyType.Bachelor)
                type = "бакалавриат";
            else if (Type == StudyType.Master)
                type = "магистратура";
            else
                type = "специалитет";

            info[1] = $"Номер зачётной книжки: {Number}. Группа: {Group}. Институт: {Institute}. Направление обучения: {type}.";
            return info;
        }
    }
}
