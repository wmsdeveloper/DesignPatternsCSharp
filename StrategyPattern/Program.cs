using StrategyPattern.src;
using StrategyPattern.src.Strategy;

namespace StrategyPattern {
    public class StrategyPattern {
        // This pattern should have the same methods in all concrete class, hierarching from the interface
        static void Main(string[] args) {
            Console.WriteLine("*** Strategy Pattern ***\n");

            // translate for brazilian
            TranslationStrategy translationStrategyBR = new(new BrasilianTranslation());
            translationStrategyBR.Translate("Hello");
            translationStrategyBR.Translate("Home");
            translationStrategyBR.Translate("none");

            // translate for spanish
            TranslationStrategy translationStrategyES = new(new SpanishTranslation());
            translationStrategyES.Translate("Hello");
            translationStrategyES.Translate("Home");
            translationStrategyBR.Translate("none");

            // translate for italian
            TranslationStrategy translationStrategyIT = new(new ItalianTranslation());
            translationStrategyIT.Translate("Hello");
            translationStrategyIT.Translate("Home");
            translationStrategyBR.Translate("Home");
            translationStrategyBR.Translate("none");

            Console.ReadLine();
        }
    }
}