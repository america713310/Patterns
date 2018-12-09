using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    class GreekPizza : Pizza
    {
        public GreekPizza() { }

        public override void Bake()
        {
            Console.WriteLine("Greek2");
        }

        public override void Box()
        {
            Console.WriteLine("Greek4");
        }

        public override void Cut()
        {
            Console.WriteLine("Greek3");
        }

        public override void Prepare()
        {
            Console.WriteLine("Greek1");
        }
    }
}
