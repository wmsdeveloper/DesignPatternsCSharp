namespace SimpleFactoryPattern.src.Factory {
    public class SimpleFactory : ISimpleFactory {
        public static readonly string CNT_UNKMOW_ANIMAL = "Unknown Animal cannot be instantiated";

        public override IAnimal CreateAnimal(string name) {
            switch (name) {
                case "Tiger":
                    Console.WriteLine("Creating a Tiger...");
                    return new Tiger();
                case "Dog":
                    Console.WriteLine("Creating a Dog...");
                    return new Dog();
                default: throw new ArgumentException(CNT_UNKMOW_ANIMAL);
            }
        }
    }
}