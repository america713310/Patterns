using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class Amplifier
    {
        public void SetSurrounSound()
        {
            Console.WriteLine("SetSurrounSound");
        }
        public void SetVolume(int value)
        {
            Console.WriteLine("SetVolume: " + value);
        }
        public void Off()
        {
            Console.WriteLine("Off");
        }
    }
}
