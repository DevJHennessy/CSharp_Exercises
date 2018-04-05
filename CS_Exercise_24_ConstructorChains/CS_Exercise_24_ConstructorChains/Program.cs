using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_24_ConstructorChains
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable
            const int myFavoriteNumber = 42;
            Console.WriteLine("My favorite number {0} will never change.", 42);

            //2.Create a variable using the keyword "var".
            var userName = "John";
            Console.WriteLine(userName);


            //3.Chain two constructors together.
            Employee employee1 = new Employee("John");
            Employee employee2 = new Employee("Jimbo", 105000);
            Console.WriteLine("Employee1 income: {0:C}. Employee2 income: {1:C}.", employee1.Income, employee2.Income);
            Console.ReadLine();

        }
    }
}
