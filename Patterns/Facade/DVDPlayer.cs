using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class DVDPlayer
    {
        public void Play()
        {
            Console.WriteLine("DVD Play");
        }
        public void Stop()
        {
            Console.WriteLine("DVD Stop");
        }
    }
}
