namespace AbstractFactoryPattern.src.Factory {

    // Abstract Factory
    public interface IAnimalFactory {
        IDog GetDog();
        ITiger GetTiger();
    }
}