using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAndAbstractClasses
{
    internal class Dog : Animal
    {
        public Dog(string name, string colour, int age, double height) : base(name, colour, age, height) { }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public override void Cry()
        {
            Console.WriteLine("Woof!");
        }
            
    }
}
