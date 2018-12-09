using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo On");
        }
        public void Off()
        {
            Console.WriteLine("Stereo Off");
        }
        public void SetCD()
        {
            Console.WriteLine("Stereo set CD");
        }
        public void SetDVD()
        {
            Console.WriteLine("Stereo set DVD");
        }
        public void SetRadio()
        {
            Console.WriteLine("Stereo radio");
        }
        public void SetVolume(int value)
        {
            Console.WriteLine("Stereo volume: " + value);
        }
    }
}
