using System;
using System.Collections.Generic;
using iterator_pat;


interface Iterator
{
    bool HasNext();
    MenuItem Next();
}

interface Menu
{
    Iterator CreateIterator();
}

class Program
{
    static void PrintMenu(Menu menu)
    {
        Iterator iterator = menu.CreateIterator();

        Console.WriteLine("MENU");
        Console.WriteLine("----");

        while (iterator.HasNext())
        {
            MenuItem menuItem = iterator.Next();
            Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Menu pancakeHouseMenu = new PancakeHouseMenu();
        Menu dinerMenu = new DinerMenu();

        PrintMenu(pancakeHouseMenu);
        PrintMenu(dinerMenu);
    }
}
