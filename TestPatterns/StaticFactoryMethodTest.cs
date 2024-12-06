/**************************************************************************************************
 * @abstract : Defines StaticFactoryMethod Tests Scenario                                         *
 * @author   : Willian Developer                                                                  *
 * @created  : 18.11.2024                                                                         *
 * @modifier : Willian Developer                                                                  *
 * @modified : 18.11.2024                                                                         *
 **************************************************************************************************/
using FluentAssertions;
using StaticFactoryMethodPattern.src;

namespace TestPatterns {
    public class StaticFactoryMethodTest {
        [Trait("Category", " Static Factory Method ")]
        [Fact(DisplayName = "Should Generate Bewteen")]
        public void ShouldGenerateBewteen() {
            // Arrange
            int betweenFrom = 1;
            int betweenTo = 789;

            // Act
            int between = RandomIntGenerator.Between(betweenFrom, betweenTo).Next();

            // Assert
            between.Should().BeInRange(betweenFrom, betweenTo);
        }

        [Trait("Category", " Static Factory Method ")]
        [Fact(DisplayName = "Should Generate GreaterThan")]
        public void ShouldGenerateGreaterThan() {
            // Arrange
            int betweenMin = 234;

            // Act
            int between = RandomIntGenerator.GreaterThan(betweenMin).Next();

            // Assert
            between.Should().BeGreaterThan(betweenMin);
        }

        [Trait("Category", " Static Factory Method ")]
        [Fact(DisplayName = "Should Generate LessThan")]
        public void ShouldGenerateLessThan() {
            // Arrange
            int betweenMax = 56412;

            // Act
            int between = RandomIntGenerator.LessThan(betweenMax).Next();

            // Assert
            between.Should().BeLessThan(betweenMax);
        }
    }
}