namespace LabInterfacesAndAbstractClasses
{
    internal interface IAnimal
    {
        int Age { get; set; }
        string Colour { get; set; }
        string Name { get; set; }

        double Height { get; set; }

        void Eat();

        void Cry();
    }
}