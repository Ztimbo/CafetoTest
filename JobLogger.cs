using CafetoTest.Exceptions;
using System;
using System.Configuration;
using System.IO;
<<<<<<< HEAD
=======
using CafetoTest.Helpers;
using CafetoTest.Messengers;
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0

namespace CafetoTest
{
    public class JobLogger
    {
<<<<<<< HEAD
        private static bool _logToFile;
        private static bool _logToConsole;

        private static bool _logMessageType;
        private static bool _logWarningType;
        private static bool _logErrorType;

        private static bool _initialized;

        public JobLogger(bool logToFile, bool logToConsole, bool logMessageType, bool logWarningType, bool logErrorType)
        {
            _logErrorType = logErrorType;
            _logMessageType = logMessageType;
            _logWarningType = logWarningType;

            _logToFile = logToFile;
            _logToConsole = logToConsole;
            _initialized = true;
        }

        public static void LogMessage(string message, bool messageType, bool warningType, bool errorType)
        {

            if (!_initialized) throw new JobLoggerNotInitializedException();

            message = message.Trim();

            if (string.IsNullOrEmpty(message))
=======
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

            _messageProcessor.SetMessenger(messenger);

            if (string.IsNullOrEmpty(message.MessageContent) || message.MessageContent.Length == 0)
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0
            {
                return;
            }

<<<<<<< HEAD
            if (!_logToConsole && !_logToFile)
            {
                throw new Exception("Invalid configuration");
            }

            if ((!_logErrorType && !_logMessageType && !_logWarningType) || (!messageType && !warningType && !errorType))
=======
            message.MessageContent = message.MessageContent.Trim();

            _messageProcessor.SetMessage(message);

            /*if ((!_logErrorType && !_logMessageType && !_logWarningType) || (!messageType && !warningType && !errorType))
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0
            {
                throw new Exception("Error or Warning or Message must be specified");
            }

            int t;

            if (messageType && _logMessageType)
            {
                t = 1;
            }

            if (errorType && _logErrorType)
            {
                t = 2;
            }

            if (warningType && _logWarningType)
            {
                t = 3;
            }

<<<<<<< HEAD
            var l = string.Empty;
=======
            string l = string.Empty;
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0

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

<<<<<<< HEAD
            File.WriteAllText(logFullFilePath, l);
=======
            System.IO.File.WriteAllText(logFullFilePath, l);
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0

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

<<<<<<< HEAD
            Console.WriteLine(DateTime.Now.ToShortDateString() + message);
=======
            Console.WriteLine(DateTime.Now.ToShortDateString() + message);*/
>>>>>>> 9d87c414f350436cf53fe399c0913a0858ae8db0
        }
    }
}