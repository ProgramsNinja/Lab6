using Лаб20;

class Program
{
    static void Main(string[] args)
    {
        DrinkBehavior tea = new Tea();
        tea.Make();

        //кофе с добавкой 
        DrinkBehavior coffee = new Coffee(true);
        coffee.Make();

        //кофе без добавки
        DrinkBehavior coffee1 = new Coffee(false);
        coffee1.Make();

        Console.Read();
    }
}