using Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter.Classes
{
    public class Turkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying to short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }
    }
}
