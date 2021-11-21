using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            DatabaseLogger dataBaseLoger = new DatabaseLogger();
            SmsLogger smsLogger = new SmsLogger();

            fileLogger.WriteLog();
            dataBaseLoger.WriteLog();
            smsLogger.WriteLog();



            //Log Manager ile yazim
            LogManager logManager = new LogManager(new FileLogger()); // <- Burada FileLogger yerine hangi logger yazilirse asagidaki satir onun metodunu cevirir.
            logManager.WriteLog();

        }
    }
}
