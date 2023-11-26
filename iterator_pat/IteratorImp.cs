using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    class IteratorImp : Iterator
    {
        private List<MenuItem> menuItems;
        private int position = 0;

        public IteratorImp(List<MenuItem> items)
        {
            menuItems = items;
        }

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = menuItems[position];
            position++;
            return menuItem;
        }
    }
}
