using Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter.Classes
{
    class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying to long distance");
        }

        public void Quack()
        {
            Console.WriteLine("Qack");
        }
    }
}
