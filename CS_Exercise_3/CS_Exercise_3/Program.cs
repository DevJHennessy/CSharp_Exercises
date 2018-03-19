using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_Exercise_3
{
    class Program
    {
        static void Main()
        {
            //1.Do a boolean comparison using a while statement.
            //string userName;
            //bool nameValidation = false;

            //while (nameValidation == false)
            //{
            //    Console.WriteLine("Enter your name: ");
            //    userName = Console.ReadLine();

            //    if (Regex.IsMatch(userName, "^[a-zA-Z- ]+$"))
            //    {
            //        Console.WriteLine("Congrats you didn't add any funky characters. This is a value name!");
            //        nameValidation = true;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Please enter a valid name.");
            //        nameValidation = false;
            //    }
            //    Console.ReadLine();
            //}

            //2.Do a boolean comparison using a do while statement.
            Console.WriteLine("How many eggs are in the basket?");
            int inputGuess = Convert.ToInt32(Console.ReadLine());

            bool rightGuess = inputGuess == 5;

            do
            {
                switch (inputGuess)
                {
                    case 5:
                        Console.WriteLine("Correct! There are five eggs in the basket!");
                        rightGuess = true;
                        break;
                    default:
                        Console.WriteLine("Wrong. Try again.");
                        Console.WriteLine("What's your next guess?");
                        inputGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!rightGuess);

            Console.ReadLine();

        }
    }
}
