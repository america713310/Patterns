using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class StereoCommand : ICommand
    {
        private Stereo _stereo;
        public StereoCommand(Stereo stereo)
        {
            this._stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}
