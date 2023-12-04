namespace Лаб19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RubberDuck rubberDuck = new ();
            WildDuck wildDuck = new ();
            IronDuck ironDuck = new ();
            PlushDuck plushDuck = new ();

            Console.WriteLine("Резиновая уточка");
            rubberDuck.AbilityFly();
            rubberDuck.AbilityQuack();
            rubberDuck.AbilitySwim();

            Console.WriteLine("\nДикая уточка");
            wildDuck.AbilityFly();
            wildDuck.AbilityQuack();
            wildDuck.AbilitySwim();

            Console.WriteLine("\nЖелезная уточка");
            ironDuck.AbilityFly();
            ironDuck.AbilitySwim();
            ironDuck.AbilityQuack();

            Console.WriteLine("\nПлюшевая уточка");
            plushDuck.AbilityFly();
            plushDuck.AbilitySwim();
            plushDuck.AbilityQuack();
        }
    }
}
