using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_9
{
    class DoSomething
    {
        public static int MathOperation1(int operand)
        {
            int result = operand * 3;
            return result;
        }

        public static int MathOperation2(int operand)
        {
            int result = operand + 100;
            return result;
        }

        public static int MathOperation3(int operand)
        {
            int result = operand - 42;
            return result;
        }
    }
}
