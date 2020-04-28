using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesHTTP.services
{
    public class Email: IMessage
    {
        public string Send()
        {
            return "Email send";
        }
    }
}
