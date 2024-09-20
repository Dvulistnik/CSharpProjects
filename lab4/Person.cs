using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public virtual void WriteInfo()
        {
            Console.WriteLine("Пусто");
        }
    }
}
