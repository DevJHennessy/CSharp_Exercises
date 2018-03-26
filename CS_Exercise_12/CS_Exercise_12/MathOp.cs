using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_12
{
    class MathOp
    {
        public void MathOperation(int operand1, int operand2)
        {
            int result = operand1 + 10;
            Console.WriteLine("{0} + 10 equals {1}", operand1, result);
            Console.WriteLine("Second input parameter: {0}", operand2);
            Console.ReadLine();
        }
    }
}
