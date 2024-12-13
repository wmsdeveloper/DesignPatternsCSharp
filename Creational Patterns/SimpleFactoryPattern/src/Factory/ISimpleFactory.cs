namespace SimpleFactoryPattern.src.Factory {
    public abstract class ISimpleFactory {
        public abstract IAnimal CreateAnimal(string name);
    }
}