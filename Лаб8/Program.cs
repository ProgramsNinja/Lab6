using System;
using Лаб8;

class Program
{
    static void Main(string[] args)
    {
        MenuComponent rootMenu = new Menu(" Menu");

        MenuComponent breakfastMenu = new MenuSection("Завтрак:");
        MenuComponent lunchMenu = new MenuSection("Обед:");

        MenuComponent pancake = new MenuItem("   Панкейки");
        MenuComponent omelette = new MenuItem("   Омлет");
        MenuComponent pasta = new MenuItem("   Паста");
        MenuComponent sandwich = new MenuItem("   Бутерброд");

        rootMenu.Add(breakfastMenu);
        rootMenu.Add(lunchMenu);

        breakfastMenu.Add(pancake);
        breakfastMenu.Add(omelette);

        lunchMenu.Add(pasta);
        lunchMenu.Add(sandwich);

        rootMenu.Print();

       
    }
}
