using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Operation
{
    public class processor
    {
        Icalculate calc;
        public processor(int operation)
        {
            calc = FactoryCalculate.getFactoryInstance.FactoryOperation(operation);
        }

        public void result(int fn, int sn)
        {
            calc.calculate(fn,sn);
        }
    }
}
