using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;

namespace CafetoTest.Helpers.HelperMethods
{
    public static class MessageValidator
    {
        public static void Validate(Message message)
        {
            if (string.IsNullOrEmpty(message.MessageContent) || message.MessageContent.Trim().Length == 0) throw new EmptyMessageException();

            message.MessageContent = message.MessageContent.Trim();

            if(message.MessageType == null) throw new MessageTypeNotConfiguredException();

            switch (message.MessageType)
            {
                case MessageType.Warning when message.WarningType == null:
                case MessageType.Error when message.ErrorType == null:
                    throw new MessageDetailsException();
            }
        }
    }
}
