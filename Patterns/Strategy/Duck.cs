using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    abstract class Duck
    {
        public IFlyable _flyAble;
        public string Name { get; set; }
        public abstract string GetName();
        public void setFlyBehavior(IFlyable fly)
        {
            _flyAble = fly;
        }
        public void PerformFly()
        {
            _flyAble.Fly();
        }
    }
    class AliveDuck : Duck
    {
        public AliveDuck()
        {
            _flyAble = new NoFly();
        }
        public override string GetName()
        {
            return "AliveDuck";
        }
    }

    class WoodDuck : Duck
    {
        public WoodDuck(IFlyable fly)
        {
            fly.Fly();
        }
        public override string GetName()
        {
            return "WoodDuck";
        }
    }
}
