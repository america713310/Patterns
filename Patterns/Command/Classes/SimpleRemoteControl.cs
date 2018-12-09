using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Classes
{
    class SimpleRemoteControl
    {
        private ICommand _slot;
        public SimpleRemoteControl()
        {

        }
        public void SetCommand(ICommand icommand)
        {
            this._slot = icommand;
        }
        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
