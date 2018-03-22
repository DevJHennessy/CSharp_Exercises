using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create three methods, each of which will take one integer 
            //parameter in and return an integer.The methods should do some math operation on the 
            //received parameter. Put this class in a separate.cs file in the application.


            //2. In the Main() program, ask the user what number they want to do the math operations on.

            //3. Call each method in turn, passing the user input to the method. Display the returned 
            //integer to the screen.

            Console.WriteLine("Choose a method between 1, 2, and 3 to do a math operation.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Enter a whole number to operate on.");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} * 3 equals: {1}", userInput, DoSomething.MathOperation1(userInput));
                Console.ReadLine();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Enter a whole number to operate on.");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + 100 equals: {1}", userInput, DoSomething.MathOperation2(userInput));
                Console.ReadLine();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Enter a whole number to operate on.");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - 42 equals: {1}", userInput, DoSomething.MathOperation3(userInput));
                Console.ReadLine();
            }

        }
    }
}
