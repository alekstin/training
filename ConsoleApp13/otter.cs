using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Otter : Animal
    {
        public Otter(string name) : base(name, "otter")
        {
            Species = "Otter";
        }
    }
}
