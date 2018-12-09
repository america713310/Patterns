using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Interfaces
{
    interface IIterator
    {
        object Next();
        bool HasNext();
    }
}
