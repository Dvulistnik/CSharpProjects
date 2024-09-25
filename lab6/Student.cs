using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace lab6
{
    public class Student
    {
        public string Name;
        public uint Age;

        static Student()
        {
            Console.WriteLine("Статический конструктор класса Student");
            Console.WriteLine();
        }
        public Student(string name, uint age)
        {
            if (name.Any(char.IsDigit))
            {
                throw new ArgumentException("The name cannot contain numbers");
            } else if (name.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                throw new ArgumentException("The name cannot contain special characters");
            }

            this.Name = name;
            this.Age = age;
        }
        public void WriteInfo()
        {
            Console.Write($"Имя: {Name}, Возраст: {Age}");
        }

        public void BecomeOlder()
        {
            Age++;
        }
    }
}
