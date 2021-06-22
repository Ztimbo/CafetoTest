using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;
using CafetoTest.Helpers;
using CafetoTest.Messengers.Interfaces;

namespace CafetoTest.Messengers.Implementations
{
    public class Console : IListMessenger
    {
        public void SaveMessage(Message message)
        {
            var completeMessage = $"Message: {message.MessageContent} Message type: {message.MessageType}";

            switch (message.MessageType)
            {
                case MessageType.Warning:
                    completeMessage += $" Warning Type: {message.WarningType}";
                    break;
                case MessageType.Error:
                    completeMessage += $" Error Type: {message.ErrorType}";
                    break;
                case MessageType.Message:
                    break;
                default:
                    throw new MessageTypeNotConfiguredException();
            }

            System.Console.WriteLine(completeMessage);
        }
    }
}
