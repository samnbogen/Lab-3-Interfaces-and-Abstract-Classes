using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAndAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> list = new List<IAnimal>();

            Console.WriteLine("What is your dog's name? ");
            string dogName = Console.ReadLine();

            Console.WriteLine("What colour is your dog? ");
            string dogColour = Console.ReadLine();

            Console.WriteLine("How old is your dog? ");
            string dogAgeInput = Console.ReadLine();
            int dogAge = int.Parse(dogAgeInput);

            Console.WriteLine("How tall is your dog (in cm)? ");
            string dogHeightInput = Console.ReadLine();
            int dogHeight = int.Parse(dogHeightInput);

            IAnimal dog = new Dog(dogName, dogColour, dogAge, dogHeight);
            dog.Eat();
            Console.Write(dogName + " says: "); 
            dog.Cry();
            list.Add(dog);

            Console.WriteLine("What is your cat's name? ");
            string catName = Console.ReadLine();

            Console.WriteLine("What colour is your cat? ");
            string catColour = Console.ReadLine();

            Console.WriteLine("How old is your cat? ");
            string catAgeInput = Console.ReadLine();
            int catAge = int.Parse(catAgeInput);

            Console.WriteLine("How tall is your cat (in cm)? ");
            string catHeightInput = Console.ReadLine();
            int catHeight = int.Parse(catHeightInput);

            IAnimal cat = new Cat(catName, catColour, catAge, catHeight);            
            cat.Eat();
            Console.Write(catName + " says: ");
            cat.Cry();
            list.Add(cat);

            foreach (IAnimal pet in list)
            {
                Console.WriteLine(pet.ToString());
            }
        }
    }
}
