namespace AbstractFactoryPattern.src.Factory {

    // Concrete Factory-Pet Animal Factory
    public class PetAnimalFactory : IAnimalFactory {
        public IDog GetDog() {
            return new PetDog();
        }

        public ITiger GetTiger() {
            return new PetTiger();
        }
    }
}