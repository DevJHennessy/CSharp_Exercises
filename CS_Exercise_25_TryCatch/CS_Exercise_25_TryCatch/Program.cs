using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_25_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for his age.
            try
            {
                Console.WriteLine("Hello. What is your age?");
                int userInput = Convert.ToInt32(Console.ReadLine());
                //Having equal to zero is a bit silly, since a person can be less than a year old.
                if (userInput <= 0)
                {
                    throw new BelowZeroException();
                }
                DateTime yearBorn = DateTime.Now.AddYears(-userInput);
                Console.WriteLine("The year you were born: {0}. Note: this is only accurate if your birthday has passed this year. If it has not, subtract a year.", yearBorn.Year);
                Console.ReadLine();
            }
            catch (BelowZeroException)
            {
                Console.WriteLine("The number you entered is below zero. Please enter only positive whole digits.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {

                Console.WriteLine("An error has occured. Please enter positive whole digits.");
                Console.ReadLine();
                return;
            }


            //2.Display the year user born.


            //3.Exceptions must be handled using "try .. catch".

            //4.Display appropriate error messages if user enters zero or negative numbers.

            //5.Display a general message if exception caused by anything else.
        }
    }
}
