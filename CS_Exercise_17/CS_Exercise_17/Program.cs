using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Overload the "==" operator so it checks if two Employee objects are equal
            //by comparing their Id property.
            //If == overload is commented out, the else statement will execute because it is checking
            //for equality on Id's.

            Employee employee1 = new Employee() { FirstName = "Bob", LastName = "Belcher", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Linda", LastName = "Belcher", Id = 1 };
            if (employee1 == employee2)
            {
                Console.WriteLine("Two of the employees have the same ID.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No employees share the same ID.");
                Console.ReadLine();
            }


        }
    }
}
