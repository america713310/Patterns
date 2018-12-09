using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class GumballMonitor
    {
        GumballMachine _gumballMachine;
        public GumballMonitor(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + _gumballMachine.GetLocation());
            Console.WriteLine("Current inventory: " + _gumballMachine.GetCount() + " gumballs");
            Console.WriteLine("Current state: " + _gumballMachine.GetState());
        }
    }
}
