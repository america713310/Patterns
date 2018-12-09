using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class MenuItem
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;
        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price
            )
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public bool IsVegetarian()
        {
            return _vegetarian;
        }
        public double GetPrice()
        {
            return _price;
        }
    }
}
