/**************************************************************************************************
 * @abstract : Defines SimpleFactory Tests Scenario                                               *
 * @author   : Willian Developer                                                                  *
 * @created  : 18.11.2024                                                                         *
 * @modifier : Willian Developer                                                                  *
 * @modified : 18.11.2024                                                                         *
 **************************************************************************************************/
using FluentAssertions;
using SimpleFactoryPattern.src;
using SimpleFactoryPattern.src.Factory;

namespace TestPatterns.Creational_Patterns {
    public class SimpleFactoryTest {
        [Trait("Category", " Simple Factory ")]
        [Fact(DisplayName = "Should Create Dog Animal")]
        public void ShouldCreateDogAnimal() {
            // Arrange
            ISimpleFactory factory = new SimpleFactory();

            // Act
            IAnimal animal = factory.CreateAnimal("Dog");
            animal.Speak();
            animal.Action();

            // Assert
            animal.Should().BeOfType<Dog>();
        }

        [Trait("Category", " Simple Factory ")]
        [Fact(DisplayName = "Should Create Tiger Animal")]
        public void ShouldCreateTigerAnimal() {
            // Arrange
            ISimpleFactory factory = new SimpleFactory();

            // Act
            IAnimal animal = factory.CreateAnimal("Tiger");
            animal.Speak();
            animal.Action();

            // Assert
            animal.Should().BeOfType<Tiger>();
        }


        [Trait("Category", " Simple Factory ")]
        [Fact(DisplayName = "Should Throw Unknow Animal")]
        public void ShouldThrowUnknowAnimal() {
            // Arrange
            ISimpleFactory factory = new SimpleFactory();

            // Act
            Action act = () => factory.CreateAnimal("Unknow");

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(SimpleFactory.CNT_UNKMOW_ANIMAL, exception.Message);
        }
    }
}