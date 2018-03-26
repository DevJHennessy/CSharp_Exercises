using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1.Create a class. In that class, create a method that will take in an integer, do a 
            //math operation to it and then return the answer as an integer.


            //2. In the Main() method of the console app, instantiate the class and call the one 
            //method, passing in an integer. 3. Display the result to the screen.

            PerformMath performMath = new PerformMath();

            //int result = performMath.MathOperation1(5);
            //Console.WriteLine("5 + 10 equals {0}", result);
            //Console.ReadLine();


            //3. Add a second method to the class, with the same name, that will take in a decimal, 
            //do a different math operation to it and then return the answer as an integer.

            //4. In the Main() method of the console app, instantiate the class and call the second
            //method, passing in a decimal. Display the result to the screen.

            //decimal result = performMath.MathOperation1(20.50m);
            //Console.WriteLine("20.50 + 50 equals {0}", result);
            //Console.ReadLine();

            //5. Add a third method to the class, with the same name, that will take in a string, 
            //convert it to an integer if possible, do a different math operation to it and then 
            //return the answer as an integer.

            //6. In the Main() method of the console app, instantiate the class and call the third
            //method, passing in a string that equates to an integer.Display the result to the screen.
            int result = performMath.MathOperation1("5");
            Console.WriteLine("5 * 5 equals {0}", result);
            Console.ReadLine();
        }
    }
}
