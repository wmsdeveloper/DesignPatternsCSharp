using StaticFactoryMethodPattern.src;

namespace StaticFactoryMethodPattern {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("*** Static Factory Method Pattern ***\n");

            int between = RandomIntGenerator.Between(1, 789).Next();
            Console.WriteLine($"Between value from 1 and 789 is: {between}");

            int greaterThan = RandomIntGenerator.GreaterThan(234).Next();
            Console.WriteLine($"Bigger than value from 234 is: {greaterThan}");

            int lessThan = RandomIntGenerator.LessThan(56412).Next();
            Console.WriteLine($"Less than value from 56412 is: {lessThan}");

            Console.ReadKey();

        }
    }
}