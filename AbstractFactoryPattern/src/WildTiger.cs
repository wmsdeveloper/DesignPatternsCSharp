namespace AbstractFactoryPattern.src {
    public class WildTiger : ITiger {
        public void Action() {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }

        public void Speak() {
            Console.WriteLine("Wild Tiger says: Halum.");
        }
    }
}