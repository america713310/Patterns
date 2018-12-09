using Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter.Classes
{
    public class DuckAdapter : IDuck
    {
        private Turkey _duck;
        public DuckAdapter(Turkey turkey)
        {
            this._duck = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                this._duck.Fly();
            }
        }

        public void Quack()
        {
            this._duck.Gobble();
        }
    }
}
