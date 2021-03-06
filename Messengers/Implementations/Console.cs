using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;
using CafetoTest.Helpers;
using CafetoTest.Helpers.HelperMethods;
using CafetoTest.Messengers.Interfaces;

namespace CafetoTest.Messengers.Implementations
{
    public class Console : IListMessenger
    {
        public void SaveMessage(Message message)
        {
            ConsoleManagement.ConsolePrinter(message);
        }
    }
}
