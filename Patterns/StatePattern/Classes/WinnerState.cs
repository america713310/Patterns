using Patterns.StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class WinnerState : State
    {
        private GumballMachine _gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("YOU ARE THE WINNER! You get two gumballs for your quarter!");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() == 0)
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.GetCount() > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballsasd");
                    _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
                }
            }
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned a crank!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please, wait, we're already giving you a gumball!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
    }
}
