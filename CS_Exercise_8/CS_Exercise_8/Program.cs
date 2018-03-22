using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create three classes, each with getter/ setter methods but no custom 
            //constructor.These classes will take no data in and send no data out. 
            //Put each of these classes in a separate .cs file in the application.


            //2.In the Main() program, create three methods, one for each class. 
            //Each method should instantiate one of the classes. Make up the data for 
            //the instance.


            //Done.


            //3. Ask the user for which class they want to create(1, 2 or 3).
            //Based on their choice, call the applicable method that creates that class.

            //Console.WriteLine("Which class would you like to create? 1, 2, or 3?");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //if (userInput == 1)
            //{

            //    myMethod1();
            //    Console.WriteLine(myMethod1());
            //    Console.ReadLine();
            //}
            //else if (userInput == 2)
            //{
            //    myMethod2();
            //    Console.WriteLine(myMethod2());
            //    Console.ReadLine();
            //}
            //else if (userInput == 3)
            //{
            //    myMethod3();
            //    Console.WriteLine(myMethod3());
            //    Console.ReadLine();
            //}

            //4. Then display on the screen the name of the class, and the value of each 
            //property in the class.

            Console.WriteLine("Which class would you like to create? 1, 2, or 3?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {

                myMethod1();
                Console.WriteLine("You have chosen Class1, which has one property.\nProperty value: {0}", myMethod1());
                Console.ReadLine();
            }
            else if (userInput == 2)
            {
                myMethod2();
                Console.WriteLine("You have chosen Class2, which has one property.\nProperty value: {0}", myMethod2());
                Console.ReadLine();
            }
            else if (userInput == 3)
            {
                myMethod3();
                Console.WriteLine("You have chosen Class3, which has one property.\nProperty value: {0}", myMethod3());
                Console.ReadLine();
            }
            else
                return;
        }

        static private int myMethod1()
        {
            Class1 class1 = new Class1() { MyProperty = 2 };
            return class1.MyProperty;
        }

        static private string myMethod2()
        {
            Class2 class2 = new Class2() { MyProperty = "Hello!" };
            return class2.MyProperty;


        }

        static private double myMethod3()
        {
            Class3 class3 = new Class3() { MyProperty = 12.22 };
            return class3.MyProperty;
        }
    }
}

