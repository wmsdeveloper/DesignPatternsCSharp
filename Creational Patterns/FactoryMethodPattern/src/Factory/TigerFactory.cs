namespace FactoryMethodPattern.src.Factory {
    public class TigerFactory : IAnimalFactory {
        public override IAnimal CreateAnimal() {
            Console.WriteLine("Creating a Tiger...");
            return new Tiger();
        }
    }
}