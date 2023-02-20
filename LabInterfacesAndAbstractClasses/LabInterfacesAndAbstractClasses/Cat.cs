using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAndAbstractClasses
{
    internal class Cat : Animal
    {
        public Cat(string name, string colour, int age, double height) : base(name, colour, age, height) { }
        public override void Eat()
        { 
            Console.WriteLine("Cats eat mice.");
        }

        public override void Cry()
        {
            Console.WriteLine("Meow!");
        }
        
    }
}
