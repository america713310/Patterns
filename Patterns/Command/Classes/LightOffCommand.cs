using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
