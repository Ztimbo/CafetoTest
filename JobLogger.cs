using CafetoTest.Exceptions;
using System;
using System.Configuration;
using System.IO;
using CafetoTest.Helpers;
using CafetoTest.Helpers.Enumerators;
using CafetoTest.Helpers.HelperMethods;
using CafetoTest.Messengers;

namespace CafetoTest
{
    public class JobLogger
    {
        private static bool _initialized;

        private static IMessageProcessor _messageProcessor;

        public JobLogger(IMessageProcessor messageProcessor)
        {
            _initialized = true;
            
            _messageProcessor = messageProcessor;
        }

        public static void LogMessage(Message message, Messenger messenger)
        {
            if (!_initialized) throw new JobLoggerNotInitializedException();

            MessageValidator.Validate(message);

            _messageProcessor.SetMessenger(messenger);
            _messageProcessor.SetMessage(message);
        }
    }
}