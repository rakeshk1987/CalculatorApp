﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Operation
{
    class Multiply : Icalculate
    {
        public void calculate(int fn, int sn)
        {
            float result = fn * sn;
            Console.WriteLine(fn + " * " + sn + " = " + result);
        }
    }
}
