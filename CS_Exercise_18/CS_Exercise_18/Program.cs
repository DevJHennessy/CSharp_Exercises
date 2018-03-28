using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and have its data type be 
            //a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter. 
            //Assign a list of strings as the property value of Things.
            Employee<string> employee1 = new Employee<string>();
            employee1.Things.Add("Bob");
            employee1.Things.Add("Linda");
            employee1.Things.Add("Tna");

            //4. Instantiate an Employee object with type "int" as its generic parameter. 
            //Assign a list of integers as the property value of Things.
            Employee<int> employee2 = new Employee<int>();
            employee2.Things.Add(200);
            employee2.Things.Add(5001);
            employee2.Things.Add(903);
        }
    }
}
