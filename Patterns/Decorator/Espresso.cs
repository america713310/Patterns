using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Espresso : Beverage
    {
        public override double GetCost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}
