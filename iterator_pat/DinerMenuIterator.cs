using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] MenuItems;
        int position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            MenuItems = menuItems;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = MenuItems[position];
            position++;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= MenuItems.Length || MenuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}
