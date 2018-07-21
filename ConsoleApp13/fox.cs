using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Fox : Animal
    {
        public Fox(string name) : base(name, "fox")
        {
            Species = "fox";
        }
    }
}
