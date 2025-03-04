using StrategyPattern.src.Strategy;

namespace StrategyPattern.src {
    public class BrasilianTranslation : ITranslationStrategy {
        public string Translate(string word) {
            string _word =
                word.ToLower() switch {
                    "hello" => "Olá",
                    "go" => "Ir",
                    "back" => "Voltar",
                    "home" => "Casa",
                    "work" => "Trabalho",
                    _ => "not found\n",
                };

            Console.WriteLine($"Brazilian say {word} as {_word}");
            return _word;
        }
    }
}