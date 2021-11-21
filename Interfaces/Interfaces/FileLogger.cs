using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya Log yazar");
        }
    }
}
