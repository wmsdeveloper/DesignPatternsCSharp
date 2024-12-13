using StrategyPattern.src.Strategy;

namespace StrategyPattern.src {
    public class ItalianTranslation : ITranslationStrategy {
        public string Translate(string word) {
            string _word =
                word.ToLower() switch {
                    "hello" => "Ciao",
                    "go" => "Andare",
                    "back" => "Torna aqui",
                    "home" => "Casa",
                    "work" => "Lavoro",
                    _ => "not found\n",
                };

            Console.WriteLine($"Italian say {word} as {_word}");
            return _word;
        }
    }
}