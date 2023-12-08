using Лаб9;

internal class Program
{
    static void Main(string[] args)
    {
        Coffee latte = new Latte();

        latte = new Syrop(latte);
        latte = new Discount(latte);

        Console.WriteLine($"{latte.GetDescription()} цена: {latte.Price()}");
    }
}