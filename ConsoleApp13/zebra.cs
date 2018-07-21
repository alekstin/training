using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Zebra : Animal
    {
        public Zebra(string name) : base(name, "zebra")
        {
            Name = name;
            Species = "zebra";
        }
    }
}
