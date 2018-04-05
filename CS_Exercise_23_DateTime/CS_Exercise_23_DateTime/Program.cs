using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_23_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to the console.
            Console.WriteLine("The currente date and time: {0}", DateTime.Now);
            //Console.ReadLine();

            //2.Asks the user for a number.
            Console.WriteLine("Please write in a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Now.AddHours(userInput);

            //3.Prints to the console the exact time it will be in X hours, X being the number 
            //the user entered in step 2.
            Console.WriteLine("In {0} hrs it will be {1}.", userInput, dt);
            Console.ReadLine();

        }
    }
}
