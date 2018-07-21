using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zwierzaki = new List<Animal>();
            zwierzaki.Add(new Otter("Rambo"));
            zwierzaki.Add(new Otter("Rozkurwinator"));
            zwierzaki.Add(new Lion("Reksio"));
            zwierzaki.Add(new Lion("Albatros Alfa"));
            zwierzaki.Add(new Camel("Baltazar"));
            zwierzaki.Add(new Camel("Kacper"));
            zwierzaki.Add(new Zebra("Szarik"));
            zwierzaki.Add(new Zebra("Mocarny Janusz"));
            zwierzaki.Add(new Sloth("Grażyna"));
            zwierzaki.Add(new Sloth("Jessica"));
            zwierzaki.Add(new Emu("Brajan"));
            zwierzaki.Add(new Emu("Vanessa"));
            zwierzaki.Add(new Fox("Juniper"));
            zwierzaki.Add(new Fox("Fig"));
            zwierzaki.Add(new Beaver("Anastazy"));
            zwierzaki.Add(new Beaver("Tomek"));
            zwierzaki.Add(new Bear("BloodForcePL"));
            zwierzaki.Add(new Bear("ElectroShockbitch"));

            foreach (Animal name in zwierzaki)
            {
                Console.WriteLine(name);
              
                Console.ReadLine();
            }
        }
    }

    
    
    
    
    
    
    
    
    
   
}
