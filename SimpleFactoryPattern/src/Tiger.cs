namespace SimpleFactoryPattern.src {
    public class Tiger : IAnimal {
        public void Action() {
            Console.WriteLine("Tigers prefer hunting...");
        }

        public void Speak() {
            Console.WriteLine("Tiger says: Halum.");
        }
    }
}