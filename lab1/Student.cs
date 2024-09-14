using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Student
    {
        private string _name;
        public int age { get; set; }
        public Student(string name)
        {
            this._name = name;
        }
        public Student(string name, int age)
        {
            this._name = name;
            this.age = age;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Имя: {_name}, Возраст: {age}");
        }
        public void BecomeOlder()
        {
            age--;
        }
    }
}
