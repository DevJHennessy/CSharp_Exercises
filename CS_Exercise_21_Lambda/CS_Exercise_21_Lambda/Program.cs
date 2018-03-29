using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_21_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.In the Main() method, create a list of at least 10 employees. Each employee 
            //should have a first and last name, as well as an Id.At least two employees 
            //should have the first name "Joe".


            //2.Using a foreach loop, create a new list of all employees with the first name 
            //"Joe".

            //3.Do the same thing again, but this time with a lambda expression.

            //4.Using a lambda expression, make a list of all employees with an Id number greater 
            //than 5.

           List <Employee> employees = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Bob", Id = 01 },
                new Employee { FirstName = "Babs", LastName = "Kramer", Id = 02 },
                new Employee { FirstName = "Joe", LastName = "McConley", Id = 03 },
                new Employee { FirstName = "Nancy", LastName = "Vegan", Id = 04 },
                new Employee { FirstName = "Kara", LastName = "Sombre", Id = 05 },
                new Employee { FirstName = "Jimbo", LastName = "PaTimbo", Id = 06 },
                new Employee { FirstName = "Gary", LastName = "Dino", Id = 07 },
                new Employee { FirstName = "Joe", LastName = "Swazzy", Id = 08 },
                new Employee { FirstName = "Josephine", LastName = "Lorbella", Id = 09 },
                new Employee { FirstName = "Rhonda", LastName = "Bushwacker", Id = 10 }
            };

            //Console.WriteLine("Employees with the first name Joe:");
            //foreach (var employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        Console.WriteLine("{0} {1} Employee ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            //    }
            //}
            //Console.ReadLine();


            List<Employee> names = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("List of all the employees named Joe:");
            foreach (var name in names)
            {
                Console.WriteLine("{0} {1}", name.FirstName, name.LastName);

            }
            List<Employee> newList = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("All the employees with ID's greater than five:");
            foreach (var name in newList)
            {
                Console.WriteLine("{0} {1} ID: {2}", name.FirstName, name.LastName, name.Id);

            }

            Console.ReadLine();
        }
    }
}
