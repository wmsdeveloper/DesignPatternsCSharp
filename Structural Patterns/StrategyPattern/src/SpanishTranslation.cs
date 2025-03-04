using StrategyPattern.src.Strategy;

namespace StrategyPattern.src {
    public class SpanishTranslation : ITranslationStrategy {
        public string Translate(string word) {
            string _word =
                word.ToLower() switch {
                    "hello" => "Hola",
                    "go" => "Ir",
                    "back" => "Regresa",
                    "home" => "Casa",
                    "work" => "Trabajo",
                    _ => "not found\n",
                };

            Console.WriteLine($"Spanish say {word} as {_word}");
            return _word;
        }
    }
}