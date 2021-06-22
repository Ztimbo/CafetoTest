using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafetoTest.Messengers.Interfaces;

namespace CafetoTest.Messengers.Implementations
{
    public class Database : IListMessenger
    {
        public void SaveMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
