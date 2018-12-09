using Patterns.Iterator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class PancakeHouseMenuIterator : IIterator
    {
        private ArrayList _items;
        private int position = 0;
        public PancakeHouseMenuIterator(ArrayList items)
        {
            this._items = items;
        }
        public object Next()
        {
            var menuItem = _items[position];
            position += 1;
            return menuItem;
        }
        public bool HasNext()
        {
            if (position >= _items.Count || _items[position] == null)
                return false;
            else
                return true;
        }
    }
}
