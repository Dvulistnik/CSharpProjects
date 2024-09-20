using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ITStudent : Student
    {
        public ITStudent(string name, uint age) : base(name, age)
        {
        }
        public void WriteInfo()
        {
            Console.WriteLine($"ITStudent Имя {Name}, Возраст: {Age}");
        }
    }
}
