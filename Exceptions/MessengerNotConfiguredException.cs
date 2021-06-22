using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Exceptions
{
    public class MessengerNotConfiguredException : Exception
    {
        public MessengerNotConfiguredException() : base("This destination is not supported")
        {

        }
    }
}
