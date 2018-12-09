using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinnerMenu;
        public Waitress(
            IMenu pancakeHouseMenu,
            IMenu dinnerMenu
            )
        {
            this._pancakeHouseMenu = pancakeHouseMenu;
            this._dinnerMenu = dinnerMenu;
        }
        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinnerIterator = _dinnerMenu.CreateIterator();
            Console.WriteLine("Menu for breakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("Menu for lunch");
            PrintMenu(dinnerIterator);
        }
        public void PrintMenu(IIterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.GetName() + " ");
                Console.Write(menuItem.GetDescription() + " ");
                Console.Write(menuItem.IsVegetarian() + " ");
                Console.Write(menuItem.GetPrice());
                Console.WriteLine();
            }
        }
    }
}
