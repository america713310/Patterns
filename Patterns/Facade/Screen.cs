﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen Up");
        }
        public void Down()
        {
            Console.WriteLine("Screen Down");
        }
    }
}
