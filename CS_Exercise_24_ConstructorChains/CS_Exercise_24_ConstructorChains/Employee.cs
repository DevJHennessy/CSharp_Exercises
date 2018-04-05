using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_24_ConstructorChains
{
    class Employee
    {
        public int Income { get; set; }
        public string Name { get; set; }

        public Employee(string name) : this(name, 90000)
        {

        }

        public Employee(string name, int income)
        {
            Name = name;
            Income = income;

        }
    }
}
