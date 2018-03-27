using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a class. In that class, create a method that takes two integers as parameters.
            //Make one of them optional. Have the method do a math operation and return a integer
            //result.

            //2. In the Main() method of the console app, instantiate the class.

            MathOp mathoperation = new MathOp();


            //3. Ask the user to input two numbers, one at a time. Let them know they need not enter 
            //anything for the second number.

            //int userInput = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Please enter two numbers. The second number is optional.");


            //if (!string.IsNullOrEmpty(userInput2.ToString()))

            int number = 0;
            int number2 = 0;
            bool userInput = int.TryParse(Console.ReadLine(), out number);
            bool userInput2 = int.TryParse(Console.ReadLine(), out number2);

            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int userInput2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("{0} + {1} + 10 equals {2}.", number, number2, mathoperation.MatherOperation(number, number2));
            Console.ReadLine();


            //4. Call the method in the class, passing in the one or two numbers entered.


            //5. Try various combinations of numbers on the code, including having no second number.
        }
    }
}
