namespace Лаб14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem[] menuItemsArray = {
            new MenuItem("Салат", true),
            new MenuItem("бургер", false),
            new MenuItem("Чечевичный суп с томатами", true),
            new MenuItem("Свекольные чипсы", true),
            new MenuItem("Шашлык", false),
            new MenuItem("Пица", false)
        };

            List<MenuItem> menuItemsList = new List<MenuItem>(menuItemsArray);

            IIterator<MenuItem> arrayIterator = new MenuArrayIterator(menuItemsArray);
            IIterator<MenuItem> reverseListIterator = new MenuReverseListIterator(menuItemsList);
            IIterator<MenuItem> veganIterator = new MenuVeganIterator(menuItemsList);

            Console.WriteLine("Меню :");
            PrintMenu(arrayIterator);

            Console.WriteLine("\nОбратное меню:");
            PrintMenu(reverseListIterator);

            Console.WriteLine("\nВеганское меню :");
            PrintMenu(veganIterator);
        }
        static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name}");
            }
        }
    }
}
