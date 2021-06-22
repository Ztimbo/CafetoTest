using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Exceptions
{
    public class EmptyMessageException : Exception
    {
        public EmptyMessageException() : base("You must define a message")
        {

        }
    }
}
