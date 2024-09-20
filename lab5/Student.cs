using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Student : IPerson, IComparable<Student>, ICloneable
    {

        public string Name { get; set; }
        public uint Age;
        public Subject? favoriteSubject { get; set; }

        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void WriteInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }

        public void BecomeOlder()
        {
            Age++;
        }

        public override string ToString()
        {
            return "Переопределил " + base.ToString();
        }

        public int CompareTo(Student? other)
        {
            return Age.CompareTo(other?.Age);
        }
        public object Clone()
        {
            return new Student(this.Name, this.Age);
        }
    }
}
