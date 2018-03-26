using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_10
{
    class PerformMath
    {
        public int MathOperation1(int operand)
        {
            int result = operand + 10;
            return result;
        }

        public decimal MathOperation1(decimal operand)
        {
            //int result = Convert.ToInt32(operand) + 50;
            decimal result = operand + 50;
            return result;
        }

        public int MathOperation1(string operand)
        {
            int result = Convert.ToInt32(operand) * 5;
            return result;
        }
    }
}
