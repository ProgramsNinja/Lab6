using Лаб10;

public class Client
{
    public static void Main()
    {
        Facade facade = new Facade();
        facade.On();
        facade.Off();
        Console.ReadLine();
    }
}