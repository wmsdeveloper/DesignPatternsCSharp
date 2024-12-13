/**************************************************************************************************
 * @abstract : Defines Strategy Tests Scenario                                                    *
 * @author   : Willian Developer                                                                  *
 * @created  : 19.11.2024                                                                         *
 * @modifier : Willian Developer                                                                  *
 * @modified : 19.11.2024                                                                         *
 **************************************************************************************************/
using FluentAssertions;
using StrategyPattern.src;
using StrategyPattern.src.Strategy;

namespace TestPatterns.Structural_Patterns {
    public class StrategyTest {
        [Trait("Category", " Strategy Pattern ")]
        [Fact(DisplayName = "Should Translate to Brazilian")]
        public void ShouldTranslateToBrazilian() {
            // Arrange
            TranslationStrategy translationBR = new();
            translationBR.SetStrategy(new BrasilianTranslation());

            // Act
            string result = translationBR.Translate("Hello");

            // Assert
            result.Should().NotBe("not found\n");
        }

        [Trait("Category", " Strategy Pattern ")]
        [Fact(DisplayName = "Should Translate to Spanish")]
        public void ShouldTranslateToSpanish() {
            // Arrange
            TranslationStrategy translationES = new();
            translationES.SetStrategy(new SpanishTranslation());

            // Act
            string result = translationES.Translate("Hello");

            // Assert
            result.Should().NotBe("not found\n");
        }

        [Trait("Category", " Strategy Pattern ")]
        [Fact(DisplayName = "Should Translate to Italian")]
        public void ShouldTranslateToItalian() {
            // Arrange
            TranslationStrategy translationIT = new();
            translationIT.SetStrategy(new ItalianTranslation());

            // Act
            string result = translationIT.Translate("Hello");

            // Assert
            result.Should().NotBe("not found\n");
        }

        [Trait("Category", " Strategy Pattern ")]
        [Fact(DisplayName = "Should Not Translate")]
        public void ShouldNotTranslate() {
            // Arrange
            TranslationStrategy translationBR = new();
            translationBR.SetStrategy(new BrasilianTranslation());

            // Act
            string result = translationBR.Translate("none");

            // Assert
            result.Should().Be("not found\n");
        }
    }
}