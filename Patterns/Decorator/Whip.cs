using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Whip : Beverage
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 0.59;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
