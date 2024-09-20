using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Student
    {

        private static string _university;

        public string Name;
        public uint Age;
        public static string University
        {
            get
            {
                return _university;
            }
            set
            {
                _university = value;
            }
        }

        static Student()
        {
            Console.WriteLine("Статический конструктор класса Student");
            Console.WriteLine();
        }
        public Student()
        {
            this.Name = "Student";
            this.Age = 0;
        }
        public Student(string name)
        {
            this.Name = name;
        }
        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void WriteInfo()
        {
            Console.Write($"Имя: {Name}, Возраст: {Age}, Университет {University}");
        }

        public void BecomeOlder()
        {
            Age++;
        }
    }
}
