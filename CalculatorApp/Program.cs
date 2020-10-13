using CalculatorApp.Operation;
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            var fn = Console.ReadLine();

            Console.WriteLine("Enter second Number");
            var sn = Console.ReadLine();

            Console.WriteLine("Enter the operation. \n 0 for Add \n 1 for Substract \n 2 for multiply \n 3 for divide");
            var operation = Console.ReadLine();

            processor prc = new processor(Int32.Parse(operation));
            prc.result(Int32.Parse(fn), Int32.Parse(sn));
        }
    }
}
