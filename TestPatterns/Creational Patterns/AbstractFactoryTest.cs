/**************************************************************************************************
 * @abstract : Defines Abstract Factory Tests Scenario                                            *
 * @author   : Willian Developer                                                                  *
 * @created  : 19.11.2024                                                                         *
 * @modifier : Willian Developer                                                                  *
 * @modified : 19.11.2024                                                                         *
 **************************************************************************************************/
using AbstractFactoryPattern.src;
using AbstractFactoryPattern.src.Factory;
using FluentAssertions;

namespace TestPatterns.Creational_Patterns {
    public class AbstractFactoryTest {

        [Trait("Category", " Abstract Factory ")]
        [Fact(DisplayName = "Should Create Wild Dog")]
        public void ShouldCreateWildDog() {
            // Arrange
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();

            // Act
            IDog wildDog = wildAnimalFactory.GetDog();
            wildDog.Speak();
            wildDog.Action();


            // Assert
            wildDog.Should().BeOfType<WildDog>();
        }

        [Trait("Category", " Abstract Factory ")]
        [Fact(DisplayName = "Should Create Wild Tiger")]
        public void ShouldCreateWildTiger() {
            // Arrange
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();

            // Act
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();


            // Assert
            wildTiger.Should().BeOfType<WildTiger>();
        }

        [Trait("Category", " Abstract Factory ")]
        [Fact(DisplayName = "Should Create Pet Dog")]
        public void ShouldCreatePetDog() {
            // Arrange
            IAnimalFactory petAnimalFactory = new PetAnimalFactory();

            // Act
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();


            // Assert
            petDog.Should().BeOfType<PetDog>();
        }

        [Trait("Category", " Abstract Factory ")]
        [Fact(DisplayName = "Should Create Pet Tiger")]
        public void ShouldCreatePetTiger() {
            // Arrange
            IAnimalFactory petAnimalFactory = new PetAnimalFactory();

            // Act
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();


            // Assert
            petTiger.Should().BeOfType<PetTiger>();
        }

    }
}