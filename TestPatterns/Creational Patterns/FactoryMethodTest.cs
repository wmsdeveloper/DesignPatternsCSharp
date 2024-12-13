/**************************************************************************************************
 * @abstract : Defines FactoryMethod Tests Scenario                                               *
 * @author   : Willian Developer                                                                  *
 * @created  : 19.11.2024                                                                         *
 * @modifier : Willian Developer                                                                  *
 * @modified : 19.11.2024                                                                         *
 **************************************************************************************************/
using FactoryMethodPattern.src;
using FactoryMethodPattern.src.Factory;
using FluentAssertions;

namespace TestPatterns.Creational_Patterns {
    public class FactoryMethodTest {
        [Trait("Category", " Factory Method")]
        [Fact(DisplayName = "Should Create Dog Animal")]
        public void ShouldCreateDogAnimal() {
            // Arrange
            IAnimalFactory dogFactory = new DogFactory();

            // Act
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();

            // Assert
            aDog.Should().BeOfType<Dog>();
        }

        [Trait("Category", " Factory Method")]
        [Fact(DisplayName = "Should Create Tiger Animal")]
        public void ShouldCreateTigerAnimal() {
            // Arrange
            IAnimalFactory tigerFactory = new TigerFactory();

            // Act
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            // Assert
            aTiger.Should().BeOfType<Tiger>();
        }

        [Trait("Category", " Factory Method")]
        [Fact(DisplayName = "Should Make Dog Animal")]
        public void ShouldMakeDogAnimal() {
            // Arrange
            IAnimalFactory dogFactory = new DogFactory();

            // Act
            IAnimal aDog = dogFactory.MakeAnimal();

            // Assert
            aDog.Should().BeOfType<Dog>();
        }

        [Trait("Category", " Factory Method")]
        [Fact(DisplayName = "Should Make Tiger Animal")]
        public void ShouldMakeTigerAnimal() {
            // Arrange
            IAnimalFactory tigerFactory = new TigerFactory();

            // Act
            IAnimal aTiger = tigerFactory.MakeAnimal();

            // Assert
            aTiger.Should().BeOfType<Tiger>();
        }

    }
}