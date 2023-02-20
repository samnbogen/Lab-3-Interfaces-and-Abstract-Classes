using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAndAbstractClasses
{
    internal abstract class Animal : IAnimal
    {
        protected string name;
        protected string colour;
        protected int age;
        private double height;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
                
        double IAnimal.Height 
        { 
            get { return height; }
            set { height = value; }
        }

        public Animal(string name, string colour, int age, double height)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
            this.height = height;
        }

        public abstract void Eat();

        public abstract void Cry();

        public override string ToString()
        {
            string formatted = "";

            formatted += "Your pet's name is: " + this.Name + "\n" + "The colour of your pet is: " + this.Colour + "\n" + "The age of your pet is: " + this.Age + "\n" + "The height of your pet is: " + this.height + "\n"; ;

            return formatted;
        }

    }
}
