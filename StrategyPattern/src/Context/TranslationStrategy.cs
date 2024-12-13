namespace StrategyPattern.src.Strategy {
    public class TranslationStrategy {
        private ITranslationStrategy _strategy;

        /*It's our choice. We prefer to use a contructor instead of
        using a setter method. We can call this method whenever we want to
        change the "choice behavior" on the fly*/
        public TranslationStrategy(ITranslationStrategy strategy) {
            _strategy = strategy;
        }

        public string Translate(string word) {
            return _strategy.Translate(word);
        }
    }
}