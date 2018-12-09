using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Classes
{
    class ObservableSubject : IObservable
    {
        private List<IObserver> _observerList = new List<IObserver>();
        public void Delete(IObserver o)
        {
            _observerList.Remove(o);
        }

        public void Register(IObserver o)
        {
            _observerList.Add(o);
        }

        public void Notify(string message)
        {
            foreach (var item in _observerList)
            {
                item.Display(message);
            }
        }

        public void SendMessage(string user, string message)
        {
            Notify(user + ": " + message);
        }
    }
}
