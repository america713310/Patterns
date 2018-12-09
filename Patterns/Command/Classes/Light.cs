using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("Light switched on");
        }
        public void Off()
        {
            Console.WriteLine("Light switched off");
        }
    }
}
