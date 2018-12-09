using Patterns.StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class NoQuarterState : State
    {
        private GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter!");
        }

        public void InsertQuarter()
        {
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
            Console.WriteLine("You inserted a quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter!");
        }
    }
}
