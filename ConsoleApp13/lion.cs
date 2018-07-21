using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Lion : Animal
    {
        public Lion(string name) : base(name, "lion")
        {
            Species = "Lion";
        }
    }
}
