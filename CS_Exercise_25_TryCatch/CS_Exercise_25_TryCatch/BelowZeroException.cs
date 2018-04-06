using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_25_TryCatch
{
    class BelowZeroException : Exception
    {
        public BelowZeroException() : base()
        {

        }

        public BelowZeroException(string message) : base(message)
        {

        }
    }
}
