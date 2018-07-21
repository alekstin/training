using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Beaver : Animal
    {
        public Beaver(string name) : base(name, "beaver")
        {
            Species = "beaver";
        }
    }
}
