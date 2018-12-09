using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Classes
{
    class ObserverMicrosoft : IObserver, IDisplayElement
    {
        private IObservable _observer;
        private string _message;

        public ObserverMicrosoft(IObservable o)
        {
            this._observer = o;
            this._observer.Register(this);
        }

        public void Display()
        {
            Console.WriteLine("Microsoft: " + this._message);
        }

        public void Display(string message)
        {
            this._message = message;
            Display();
        }
    }
}
