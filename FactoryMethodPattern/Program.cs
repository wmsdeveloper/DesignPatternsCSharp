using FactoryMethodPattern.src;
using FactoryMethodPattern.src.Factory;

namespace FactoryMethodPattern {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*** Factory Method Pattern ***\n");

            // Creating a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();

            // Creating a tiger using the Factory Method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            // Creating a DogFactory
            IAnimalFactory dogFactory = new DogFactory();

            // Creating a dog using the Factory Method
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();

            // Making a tiger using parent rules
            tigerFactory.MakeAnimal();

            // Making a dog using parent rules
            dogFactory.MakeAnimal();

            Console.ReadKey();
        }
    }
}