using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    //implementation of the PancakeHouseMenu
    class PancakeHouseMenu : Menu
    {
        private ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            // Add menu items
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        private void AddItem(string name, string desc, bool vege, double price)
        {
            MenuItem menuItem = new MenuItem(name, desc, vege, price);
            menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new IteratorImp(menuItems);
        }
    }
}
