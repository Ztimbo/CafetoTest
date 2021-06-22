using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Messengers.Interfaces
{
    public interface IListMessenger
    {
        void SaveMessage(Message message);
    }
}
