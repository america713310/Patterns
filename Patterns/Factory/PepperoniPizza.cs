using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza() { }

        public override void Bake()
        {
            Console.WriteLine("Pepper2");
        }

        public override void Box()
        {
            Console.WriteLine("Pepper4");
        }

        public override void Cut()
        {
            Console.WriteLine("Pepper3");
        }

        public override void Prepare()
        {
            Console.WriteLine("Pepper1");
        }
    }
}
