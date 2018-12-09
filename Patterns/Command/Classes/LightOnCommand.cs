using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
