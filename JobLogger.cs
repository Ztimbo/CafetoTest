using CafetoTest.Exceptions;
using System;
using System.Configuration;
using System.IO;
using CafetoTest.Helpers;
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

            /*

            string l = string.Empty;

            var logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];
            if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;
            var logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
            var logFullFilePath = Path.Combine(logFolder, logFileName);

            if (File.Exists(logFullFilePath))
            {
                l = File.ReadAllText(logFullFilePath);

            }

            if (errorType && _logErrorType)
            {
                l = l + DateTime.Now.ToShortDateString() + " Error   " + message + Environment.NewLine;
            }

            if (warningType && _logWarningType)
            {
                l = l + DateTime.Now.ToShortDateString() + " Warning " + message + Environment.NewLine;
            }

            if (messageType && _logMessageType)
            {
                l = l + DateTime.Now.ToShortDateString() + " Message " + message + Environment.NewLine;
            }


            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

            System.IO.File.WriteAllText(logFullFilePath, l);

            if (errorType && _logErrorType)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            if (warningType && _logWarningType)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            if (messageType && _logMessageType)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(DateTime.Now.ToShortDateString() + message);*/
        }
    }
}