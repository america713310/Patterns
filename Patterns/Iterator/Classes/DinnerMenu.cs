using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class DinnerMenu : IMenu
    {
        private const int _MaxItems = 6;
        private int _NumberOfItems = 0;
        private MenuItem[] menuItems;

        public DinnerMenu()
        {
            menuItems = new MenuItem[_MaxItems];
            AddItem("Bacon", "With tomato", false, 3.99);
            AddItem("Bacon", "With tomato", false, 3.99);
            AddItem("Bacon", "With tomato", false, 3.99);
            AddItem("Bacon", "With tomato", false, 3.99);
        }
        public void AddItem(
            string name,
            string description,
            bool vegetarian,
            double price
            )
        {
            MenuItem menuItem = new MenuItem(
                name,
                description,
                vegetarian,
                price
                );
            if (_NumberOfItems >= _MaxItems)
                Console.WriteLine("Sorry, menu is full!");
            else
            {
                menuItems[_NumberOfItems] = menuItem;
                _NumberOfItems += 1;
            }
        }
        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(menuItems);
        }
    }
}
