﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_18
{
    class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

    }
}
