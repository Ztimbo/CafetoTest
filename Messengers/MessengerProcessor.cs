using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Exceptions;
using CafetoTest.Helpers;
using CafetoTest.Messengers.Implementations;
using CafetoTest.Messengers.Interfaces;
using Console = CafetoTest.Messengers.Implementations.Console;

namespace CafetoTest.Messengers
{
    public class MessengerProcessor : IMessageProcessor
    {
        private IListMessenger _listMessenger;

        public void SetMessenger(Messenger messenger)
        {
            _listMessenger =
                (IListMessenger)Activator.CreateInstance(
                    Type.GetType($"CafetoTest.Messengers.Implementations.{ Enum.GetName(typeof(Messenger), messenger) }") ?? throw new MessengerNotConfiguredException());
        }

        public void SetMessage(Message message)
        {
            _listMessenger.SaveMessage(message);
        }
    }
}
