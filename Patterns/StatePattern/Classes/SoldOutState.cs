using Patterns.StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class SoldOutState : State
    {
        private GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no gumballs!");
        }
    }
}
