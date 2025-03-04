namespace StaticFactoryMethodPattern.src {
    public class RandomIntGenerator {
        private int _min = 0;
        private int _max = 0;

        private RandomIntGenerator(int min, int max) {
            _min = min;
            _max = max;
        }

        public static RandomIntGenerator Between(int min, int max) {
            return new RandomIntGenerator(min, max);
        }

        public static RandomIntGenerator GreaterThan(int min) {
            return new RandomIntGenerator(min, Int32.MaxValue);
        }

        public static RandomIntGenerator LessThan(int max) {
            return new RandomIntGenerator(Int32.MinValue, max);
        }

        public int Next() {
            int generated = new Random().Next(_min, _max);
            return generated;
        }
    }
}