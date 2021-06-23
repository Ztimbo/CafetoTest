using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Helpers.HelperMethods
{
    public static class FileManagement
    {
        public static void SaveFile(Message message)
        {
            var logFolder = ConfigurationManager.AppSettings["fileDestination"];
            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

            var logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
            var logFullFilePath = Path.Combine(logFolder, logFileName);

            var l = string.Empty;

            if (File.Exists(logFullFilePath))
            {
                l = File.ReadAllText(logFullFilePath);
            }

            l += TextBuilder.MessageBuilder(message) + Environment.NewLine;

            File.WriteAllText(logFullFilePath, l);

            Console.WriteLine(logFullFilePath);
        }
    }
}
