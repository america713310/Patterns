using Patterns.Iterator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class PancakeHouseMenu : IMenu
    {
        private ArrayList _menuItems;
        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            AddItem("K&B", "With eggs", true, 2.99);
            AddItem("K&B", "With eggs", true, 2.99);
            AddItem("K&B", "With eggs", true, 2.99);
        }
        public void AddItem(
            string name,
            string description,
            bool vegetarian,
            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }
        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}
