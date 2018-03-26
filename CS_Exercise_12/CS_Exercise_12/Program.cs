using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create a void method that takes two integers as 
            //parameters.Have the method do a math operation on the first integer and display
            //the second integer to the screen.



            //2. In the Main() method of the console app, instantiate the class.

            MathOp mathoperation = new MathOp();

            //3. Call the method in the class, passing in two numbers.

            //mathoperation.MathOperation(5, 10);

            //4. Call the method in the class, specifying the parameters by name.

            mathoperation.MathOperation(operand1: 10, operand2: 100);
        }
    }
}
