using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'e yazar.");
        }
    }
}
