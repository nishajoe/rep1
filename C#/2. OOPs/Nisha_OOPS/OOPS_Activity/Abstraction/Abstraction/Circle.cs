﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
}
