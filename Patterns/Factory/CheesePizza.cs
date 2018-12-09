using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    class CheesePizza : Pizza
    {
        public CheesePizza() { }

        public override void Bake()
        {
            Console.WriteLine("Поджарка");
        }

        public override void Box()
        {
            Console.WriteLine("Упаковка");
        }

        public override void Cut()
        {
            Console.WriteLine("Разрезка");
        }

        public override void Prepare()
        {
            Console.WriteLine("Готовка");
        }
    }
}
