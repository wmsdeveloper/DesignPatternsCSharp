namespace SimpleFactoryPattern.src {
    public class Dog : IAnimal {
        public void Action() {
            Console.WriteLine("Dog prefer barking...");
        }

        public void Speak() {
            Console.WriteLine("Dog says: Bow-Bow.");
        }
    }
}