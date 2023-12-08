using Лаб20;

class Program
{
    static void Main(string[] args)
    {
        DrinkBehavior tea = new Tea();
        tea.Make();
        DrinkBehavior coffee = new Coffee(true);
        coffee.Make();
        Console.Read();
    }
}