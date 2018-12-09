using Patterns.StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class HasQuarterState : State
    {
        private Random _random = new Random();
        private GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned!");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int _winner = _random.Next(10);
            if (_winner == 1 && _gumballMachine.GetCount() > 1)
            {
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
                Console.WriteLine(_winner);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
                Console.WriteLine(_winner);
            }
        }
    }
}
