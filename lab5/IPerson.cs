using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public interface IPerson
    {
        public string Name { get; set; }
        public void WriteInfo();
    }
}
