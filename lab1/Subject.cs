using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Subject
    {
        public string title { get; private set; }
        public Subject(string title)
        {
            this.title = title;
        }
    }
}
