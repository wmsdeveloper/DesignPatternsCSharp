using SimpleFactoryPattern.src;
using SimpleFactoryPattern.src.Factory;

namespace SimpleFactoryPattern {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*** Simple Factory Pattern ***\n");

            // Create a Simple Factory
            ISimpleFactory factory = new SimpleFactory();

            // Create Dog Animal
            IAnimal dog = factory.CreateAnimal("Dog");
            dog.Speak();
            dog.Action();

            // space between animals
            Console.WriteLine("");

            // Create Tiger Animal
            IAnimal tiger = factory.CreateAnimal("Tiger");
            tiger.Speak();
            tiger.Action();

            Console.ReadKey();
        }
    }
}