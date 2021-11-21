using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar");
        }
    }
}
