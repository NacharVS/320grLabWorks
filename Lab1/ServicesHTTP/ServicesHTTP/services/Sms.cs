using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesHTTP.services
{
    public class Sms:IMessage
    {
        public string Send()
        {
            return "Sms send";
        }
    }
}
