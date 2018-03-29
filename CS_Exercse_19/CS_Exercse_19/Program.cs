using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercse_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an enum for the days of the week.

            //2. Prompt the user to enter the current day of the week.


            //3. Assign the value to a variable of that enum data type you just created.

            //4. Wrap the above statement in a try/catch block and have it print "Please enter
            //an actual day of the week." to the console if an error occurs.

            try
            {
                Console.WriteLine("Please enter the day of the week.");
                string userInput = Console.ReadLine();
                userInput = DaysOfTheWeek.Sunday.ToString();
                //userInput = DaysOfTheWeek.Monday.ToString();
                //userInput = DaysOfTheWeek.Tuesday.ToString();
                //userInput = DaysOfTheWeek.Wednesday.ToString();
                //userInput = DaysOfTheWeek.Thursday.ToString();
                //userInput = DaysOfTheWeek.Friday.ToString();
                //userInput = DaysOfTheWeek.Saturday.ToString(;)



                Console.WriteLine("The day of the week is {0}", userInput);
                Console.ReadLine();

            }
            catch (Exception)
            {

                Console.WriteLine("You did not enter a day of the week. Please try again.");
                Console.ReadLine();
            }
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        //if (userInput == DaysOfTheWeek.Sunday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Monday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Tuesday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Wednesday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Thursday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Friday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
        //else if (userInput == DaysOfTheWeek.Saturday.ToString())
        //{
        //    Console.WriteLine("The day of the week is {0}", userInput);
        //    Console.ReadLine();
        //}
    }
}
