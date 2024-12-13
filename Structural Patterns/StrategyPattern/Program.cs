using StrategyPattern.src;
using StrategyPattern.src.Strategy;

namespace StrategyPattern {
    public class StrategyPattern {
        static void Main(string[] args) {
            Console.WriteLine("*** Strategy Pattern ***\n");

            //-----------------------------------------------------------------------
            // NOTE: This pattern should have the same methods in all concrete class,
            //       hierarching from the interface.
            //-----------------------------------------------------------------------
            TranslationStrategy translation = new();

            // translate for brazilian
            translation.SetStrategy(new BrasilianTranslation());
            translation.Translate("Hello");
            translation.Translate("Home");
            translation.Translate("none");

            // translate for spanish
            translation.SetStrategy(new SpanishTranslation());
            translation.Translate("Hello");
            translation.Translate("Home");
            translation.Translate("none");

            // translate for italian
            translation.SetStrategy(new ItalianTranslation());
            translation.Translate("Hello");
            translation.Translate("Home");
            translation.Translate("none");

            Console.ReadLine();
        }
    }
}