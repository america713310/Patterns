using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class DinnerMenuIterator : IIterator
    {
        private MenuItem[] _items;
        private int position = 0;
        public DinnerMenuIterator(MenuItem[] items)
        {
            this._items = items;
        }
        public object Next()
        {
            MenuItem menuItem = _items[position];
            position += 1;
            return menuItem;
        }
        public bool HasNext()
        {
            if (position >= _items.Length || _items[position] == null)
                return false;
            else
                return true;
        }
    }
}
