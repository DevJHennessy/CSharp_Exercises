using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a class. In that class, create a void method that outputs an integer. Have
            //the method divide the data passed to it by 2.

            //2. In the Main() method, instantiate that class.
            MathOp mathops = new MathOp();

            //3. Have the user enter a number. Call the method on that number. Display the output
            //to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Enter a number.");
            int number = 0;
            mathops.MathOperation(out number);
            Console.WriteLine("Output: {0}", number);
            Console.ReadLine();

            //4. Create a method with output parameters.
            
        //    public void myMethod(out int beans)
        //{
        //    beans = 42;
        //}

            //5. Overload a method.

        //    public void myMethod(int someParameter)
        //{
        //    //This method doesn't do anything.
        //}

            //6. Declare a class to be static.
            //Done.
        }
    }
}
