using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Mocha : Beverage
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 3.99;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
