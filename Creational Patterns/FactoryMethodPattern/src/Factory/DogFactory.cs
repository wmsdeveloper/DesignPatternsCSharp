namespace FactoryMethodPattern.src.Factory {
    public class DogFactory : IAnimalFactory {
        public override IAnimal CreateAnimal() {
            Console.WriteLine("Creating a Dog...");
            return new Dog();
        }
    }
}