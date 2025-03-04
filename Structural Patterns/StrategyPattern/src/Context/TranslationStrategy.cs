namespace StrategyPattern.src.Strategy {
    public class TranslationStrategy {
        private ITranslationStrategy? _strategy;

        public TranslationStrategy() { }

        /*It's our choice. We prefer to use a setter method instead of
        using a constructor. We can call this method whenever we want to
        change the "choice behavior" on the fly*/
        public void SetStrategy(ITranslationStrategy strategy) {
            _strategy = strategy;
        }

        public string Translate(string word) {
            if (_strategy == null)
                throw new InvalidOperationException("Strategy is not defined");

            return _strategy.Translate(word);
        }
    }
}