using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Classes
{
    class ObserverAmazon : IObserver
    {
        private IObservable _observable;

        public ObserverAmazon(IObservable o)
        {
            this._observable = o;
            this._observable.Register(this);
        }

        public void Display(string message)
        {
            Console.WriteLine("Amazon: " + message);
        }
    }
}
