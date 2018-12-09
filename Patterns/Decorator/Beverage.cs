using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract class Beverage
    {
        public abstract double GetCost();
        public abstract string GetDescription();
    }
}
