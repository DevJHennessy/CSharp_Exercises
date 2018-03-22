using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a one-dimensional Array of strings. 
            //Ask the user to input some text. Create a loop that goes through each 
            //string in the Array, adding the user’s text to the string. 
            //Then create a loop that prints off each string in the Array on a separate line.


            //string[] myArray = new string[100];
            //int setLength = 5;

            //Console.WriteLine("Input five names in the array:\n", setLength);

            //for (int i = 0; i < setLength; i++)
            //{
            //    myArray[i] = Console.ReadLine();
            //}

            //Console.WriteLine("\nThe values stored in the array are:\n");
            //for (int i = 0; i < setLength; i++)
            //{
            //    Console.Write("{0} ", myArray[i]);
            //}
            //Console.ReadLine();

            //2.Create an infinite loop.

            //for (int i = 0; i - 1 < i++; i++)
            //{
            //    Console.WriteLine("Oh boy, you've got a problem!");
            //}

            //3.Fix the infinite loop so it will execute.

            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("No more problem!");
            //    Console.ReadLine();

            //}

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //{
            //    Console.WriteLine("No more problem!");
            //    Console.ReadLine();

            //}

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            //for (int i = 0; i <= 1; i++)
            //{
            //    Console.WriteLine("You should see this twice!");
            //    Console.ReadLine();
            //}

            //6.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //int[] milesPerHour = { 10, 50, 75, 90, 40, 102, 130, 180, 240, 40 };

            //for (int i = 0; i < milesPerHour.Length; i++)
            //{
            //    if (milesPerHour[i] > 85)
            //    {
            //        Console.WriteLine("These cars are driving fast: " + milesPerHour[i]);
            //    }
            //}
            //Console.ReadLine();


            //7.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            //int months = 12;

            //for (int i = 1; i <= months; i++)
            //{
            //    Console.WriteLine("Months counted: {0}", i);
            //}
            //Console.ReadLine();

            //8.Create a List of strings where each item in the list is unique.
            //Ask the user to select text to search for in the List.
            //Create a loop that iterates through the loop and then displays the index 
            //of the array that contains matching text on the screen.

            //List<string> words = new List<string>() { "Joy", "To", "The", "World"};
            //Console.WriteLine("Search for text in the list. Each word starts with a capital.");
            //string checkWords = Console.ReadLine();
            //foreach (var word in words)
            //{
            //    if (word == checkWords)
            //    {
            //        Console.WriteLine(words.IndexOf(word));
            //       // word.IndexOf(words);
            //    }

            //}
            //Console.ReadLine();



            //9.Add code to that above loop that tells a user if they put in text that 
            //isn’t in the List.

            //List<string> words = new List<string>() { "Joy", "To", "The", "World" };
            //Console.WriteLine("Search for text in the list. Each word starts with a capital.");
            //string checkWords = Console.ReadLine();

            //foreach (var word in words)
            //{
            //    if (word == checkWords)
            //    {
            //        Console.WriteLine(words.IndexOf(word));
            //    }
            //    else
            //    {
            //        Console.WriteLine("That word was not in the list, or perhaps it started with a lowercase instead of an uppercase.");
            //    }

            //}
            //Console.ReadLine();

            //10.Add code to that above loop that stops it from executing once a match has been found.

            //List<string> words = new List<string>() { "Joy", "To", "The", "World" };
            //Console.WriteLine("Search for text in the list. Each word starts with a capital.");
            //string checkWords = Console.ReadLine();

            //foreach (var word in words)
            //{

            //    if (word == checkWords)
            //    {
            //        Console.WriteLine(words.IndexOf(word));
            //        break;
            //    }
            //    else if (word != checkWords)
            //    {
            //        //continue;
            //        Console.WriteLine("That word was not in the list, or perhaps it started with a lowercase instead of an uppercase.");
            //        //continue;
            //       // break;

            //    }
            //}
            //Console.ReadLine();


            //11. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List.
            //Create a loop that iterates through the loop and then displays the indices of the 
            //array that contain matching text on the screen.

            List<string> words = new List<string>() { "Joy", "To", "The", "World", "Joy" };
            Console.WriteLine("Search for text in the list. Each word starts with a capital.");
            string checkWords = Console.ReadLine();

            foreach (var word in words)
            {

                if (word == checkWords)
                {
                    Console.WriteLine(words.IndexOf(word));

                }

            }
            Console.ReadLine();

            //12.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> words = new List<string>() { "Joy", "To", "The", "World", "Joy" };
            //Console.WriteLine("Search for text in the list. Each word starts with a capital.");
            //string checkWords = Console.ReadLine();

            //foreach (var word in words)
            //{

            //    if (word == checkWords)
            //    {
            //        Console.WriteLine(words.IndexOf(word));

            //    }
            //    else if (word != checkWords)
            //    {
            //        //continue;
            //        Console.WriteLine("That word was not in the list, or perhaps it started with a lowercase instead of an uppercase.");
            //        //continue;


            //    }
            //}
            //Console.ReadLine();

            //13.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and  whether or not it has already appeared in the list.
        }
    }
}
