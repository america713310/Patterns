using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Interfaces
{
    interface IFlyable
    {
        void Fly();
    }
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("NoFly");
        }
    }
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("FlyWithWings");
        }
    }
    public class FlySouth : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("FlySouth");
        }
    }
    public class FlyNorth : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("FlyNorth");
        }
    }
}
