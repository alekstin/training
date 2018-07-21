using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Emu : Animal
    {
        public Emu(string name) : base(name, "emu")
        {
            Species = "emu";
        }
    }
}
