using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Helpers;

namespace CafetoTest.Messengers
{
    public interface IMessageProcessor
    {
        void SetMessenger(Messenger messenger);
        void SetMessage(Message message);
    }
}
