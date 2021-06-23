using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;
using CafetoTest.Helpers.Enumerators;

namespace CafetoTest.Helpers.HelperMethods
{
    public static class ConsoleManagement
    {
        public static void ConsolePrinter(Message message)
        {
            var completeMessage = TextBuilder.MessageBuilder(message);

            switch (message.MessageType)
            {
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageType.Message:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    throw new MessageTypeNotConfiguredException();
            }

            Console.WriteLine(completeMessage);
        }
    }
}
