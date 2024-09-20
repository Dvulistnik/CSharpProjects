using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person
    {

        public override string Name { get; set; }
        public uint Age;

        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override void WriteInfo()
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
    }
}
