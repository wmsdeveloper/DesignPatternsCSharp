namespace AbstractFactoryPattern.src.Factory {

    // Concrete Factory-Wild Animal Factory
    public class WildAnimalFactory : IAnimalFactory {
        public IDog GetDog() {
            return new WildDog();
        }

        public ITiger GetTiger() {
            return new WildTiger();
        }
    }
}