﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_16
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}.", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit.");
            Console.ReadLine();
        }
    }
}
