using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Exceptions
{
    public class MessageDetailsException : Exception
    {
        public MessageDetailsException() : base("You must define a warning or error type type if you selected warning or error message type")
        {

        }
    }
}
