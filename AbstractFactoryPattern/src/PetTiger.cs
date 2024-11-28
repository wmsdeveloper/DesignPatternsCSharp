namespace AbstractFactoryPattern.src {
    public class PetTiger : ITiger {
        public void Action() {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }

        public void Speak() {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
    }
}