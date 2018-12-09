using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner On");
        }
        public void Off()
        {
            Console.WriteLine("Tuner Off");
        }
    }
}
