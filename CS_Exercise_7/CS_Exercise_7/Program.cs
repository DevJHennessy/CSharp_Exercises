using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each number 
            //in the list by. Write a loop that takes each integer in the list, divides it 
            //by the number the user entered, and displays the result to the screen.

            //List<int> intList = new List<int> { 2, 20, 22, 5, 8 };
            //Console.WriteLine("Input a number to divide the numbers in the list by.");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());
            //foreach (var item in intList)
            //{
            //    int results = item / inputNumber;
            //    Console.WriteLine(item + " divided by " + inputNumber + " equals: "  + results);
            //    Console.ReadLine();
            //}



            //2.Run that code, entering in non - zero numbers as the user. 
            //Look at the displayed results.

            //Done.

            //3.Run that code, entering in zero as the number to divide by. Note any error
            //messages you get.

            //DivideByZeroException was unhandled.

            //4.Run that code, entering in a string as the number to divide by. 
            //Note any error messages you get.

            //FormatException was unhandled.

            //5.Now put the loop in a try/catch block. Below and outside of the try/catch 
            //block, make the program display a message to the display to let you know the 
            //program has emerged from the try/catch block and continued on with program
            //execution. In the catch block, display the error message to the screen. 
            //Then try various combinations of user input: valid numbers, zero and a string.
            //Ensure the proper error messages display on the screen, and that the code 
            //after the try/catch block gets executed.

            try
            {
                List<int> intList = new List<int> { 2, 20, 22, 5, 8 };
                Console.WriteLine("Input a number to divide the numbers in the list by.");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                foreach (var item in intList)
                {
                    int results = item / inputNumber;
                    Console.WriteLine(item + " divided by " + inputNumber + " equals: " + results);
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("\nPlease do not input zero. You cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nWhat you entered was not an integer. Please input only whole numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("\nThe program has emerged from the try-catch exception handling.");
            Console.ReadLine();
        }
    }
}
