using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalculatorApp.Operation
{
    public class FactoryCalculate
    {
        public static List<Icalculate> calc = new List<Icalculate>();

        static FactoryCalculate instance = null;
        public static FactoryCalculate getFactoryInstance
        {
            get
            {
                if (instance == null)
                {
                    return new FactoryCalculate();
                }                    
                return instance;
            }
        }

        public FactoryCalculate()
        {
            calc.Add(new Add());
            calc.Add(new Substract());
            calc.Add(new Multiply());
            calc.Add(new Divide());
        }
        public Icalculate FactoryOperation(int optr)
        {
            return calc[optr];
        }


    }
}
