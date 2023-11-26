using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_pat
{
    // implementation of the MenuItem
    class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string desc, bool vege, double price)
        {
            Name = name;
            Description = desc;
            Vegetarian = vege;
            Price = price;
        }
    }
}
