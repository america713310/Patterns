using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Interfaces
{
    interface IObservable
    {
        void Register(IObserver o);
        void Notify(string message);
        void Delete(IObserver o);
    }
}
