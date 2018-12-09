using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SingletonPattern
{
    class Singleton
    {
        private static Singleton _instance;
        private string _name;
        private Singleton(string name)
        {
            this._name = name;
        }

        public static Singleton GetInstance(string name)
        {

            if (_instance == null)
                _instance = new Singleton(name);
            return _instance;
        }

        public string GetName
        {
            get
            {
                if (_name != null)
                    return _name;
                else
                    return "";
            }
            private set
            {
                this._name = value;
            }
        }
    }
}
