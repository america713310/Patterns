using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    class FactoryPizza
    {
        public Pizza createPizza(string type)
        {
            Pizza _pizza = null;
            if (type.Equals("cheese"))
                _pizza = new CheesePizza();
            else if (type.Equals("greeke"))
                _pizza = new GreekPizza();
            else if (type.Equals("pepperonii"))
                _pizza = new PepperoniPizza();
            return _pizza;
        }
    }
}
