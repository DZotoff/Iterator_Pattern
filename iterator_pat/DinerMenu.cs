using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    class DinerMenu : Menu
{
    private const int MAX_ITEMS = 6;
    private int numberOfItems = 0;
    private MenuItem[] menuItems;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];

        // Adding menu items
        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
        AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
        AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
    }

    private void AddItem(string name, string desc, bool vege, double price)
    {
        MenuItem menuItem = new MenuItem(name, desc, vege, price);
        if (numberOfItems < MAX_ITEMS)
        {
            menuItems[numberOfItems] = menuItem;
            numberOfItems++;
        }
    }

    public Iterator CreateIterator()
    {
        return new DinerMenuIterator(menuItems);
    }
}
}
