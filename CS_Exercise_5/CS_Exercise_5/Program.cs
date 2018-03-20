using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_5
{
    class Program
    {
        static void Main()
        {
            //1.Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            //string[] stringArray = { "Joy", "To", "The", "World" };
            //Console.WriteLine("Select an array index 0-3: ");
            //int inputSelection = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(stringArray[inputSelection]);
            //Console.ReadLine();

            //2.Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            //int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Console.WriteLine("Select an array index 0-9");
            //int inputSelection = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(intArray[inputSelection]);
            //Console.ReadLine();

            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            //int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Console.WriteLine("Select an array index 0-9");
            //int inputSelection = Convert.ToInt32(Console.ReadLine());
            //if (inputSelection > 9)
            //{
            //    Console.WriteLine("That index does not exist in the array. You can try again, or not...");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine(intArray[inputSelection]);
            //    Console.ReadLine();
            //}

            //Console.WriteLine(intArray[inputSelection]);
            //Console.ReadLine();

            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> listString = new List<string>();
            listString.Add("No");
            listString.Add("Bounce");
            listString.Add("No");
            listString.Add("Play");

            Console.WriteLine("Select an index 0-3");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(listString[inputSelection]);
            Console.ReadLine();

        }
    }
}
