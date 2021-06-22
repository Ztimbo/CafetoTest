using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Exceptions
{
    public class MessageTypeNotConfiguredException : Exception
    {
        public MessageTypeNotConfiguredException() : base("This message type is not supported")
        {

        }
    }
}
