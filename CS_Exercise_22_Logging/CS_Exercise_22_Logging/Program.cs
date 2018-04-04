using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Exercise_22_Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask a user for a number.
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //2.Log that number to a text file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Logs\inputText.txt", true))
            {
                file.WriteLine(userInput);
            }

            //3.Print the text file back to the user.
            Console.WriteLine("The number you entered: {0}.", userInput);
            Console.ReadLine();
        }
    }
}
