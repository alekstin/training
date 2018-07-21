using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public virtual void Eat()
        {
            Console.WriteLine(Species + " " + Name + " eats.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine(Species + " " + Name + " sleeps.");
        }
        public virtual void Shit()
        {
            Console.WriteLine(Species + " " + Name + " takes a shit.");
        }

    }
}
