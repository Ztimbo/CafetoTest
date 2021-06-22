using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;

namespace CafetoTest.Helpers
{
    public static class TextBuilder
    {
        public static string MessageBuilder(Message message)
        {
            var messageOutput = $"[{message.MessageDate.ToString(CultureInfo.InvariantCulture)}] Message: {message.MessageContent} Message type: {message.MessageType}";

            switch (message.MessageType)
            {
                case MessageType.Warning:
                    messageOutput += $" Warning Type: {message.WarningType}";
                    break;
                case MessageType.Error:
                    messageOutput += $" Error Type: {message.ErrorType}";
                    break;
                case MessageType.Message:
                    break;
                default:
                    throw new MessageTypeNotConfiguredException();
            }

            return messageOutput;
        }
    }
}
