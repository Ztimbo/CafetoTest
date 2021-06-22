using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Helpers;

namespace CafetoTest
{
    public class Message
    {
        public string MessageContent { get; set; }
        public MessageType MessageType { get; set; }
        public ErrorType? ErrorType { get; set; }
        public WarningType? WarningType { get; set; }
    }
}
