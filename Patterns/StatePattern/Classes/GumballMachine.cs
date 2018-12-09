using Patterns.StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StatePattern.Classes
{
    class GumballMachine
    {
        private static State _soldOutState;
        private static State _noQuarterState;
        private static State _hasQuarterState;
        private static State _soldState;
        private State _state;
        private int _count = 0;
        private string _location;
        
        public GumballMachine(int numberGumballs, string location)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            this._count = numberGumballs;
            this._location = location;
        }
        public void InsertQuarter()
        {
            _state = _noQuarterState;
            _state.InsertQuarter();
        }
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }
        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }
        public void SetState(State state)
        {
            this._state = state;
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
                _count = _count - 1;
        }
        public State GetNoQuarterState()
        {
            return new NoQuarterState(this);
        }
        public State GetHasQuarterState()
        {
            return new HasQuarterState(this);
        }
        public State GetSoldState()
        {
            return new SoldState(this);
        }
        public State GetSoldOutState()
        {
            return new SoldOutState(this);
        }
        public State GetWinnerState()
        {
            return new WinnerState(this);
        }
        public int GetCount()
        {
            return _count;
        }
        public string GetState()
        {
            return Convert.ToString(_state);
        }
        public string GetLocation()
        {
            return _location;
        }
    }
}
