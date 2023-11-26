using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    class IteratorImp : Iterator
    {
        private ArrayList menuItems;
        private int position = 0;

        public IteratorImp(ArrayList items)
        {
            menuItems = items;
        }

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = (MenuItem)menuItems[position];
            position++;
            return menuItem;
        }
    }
}
