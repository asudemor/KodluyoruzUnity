using System;

namespace csharp_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();
            
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            logManager _logManager = new logManager(new FileLogger());
            _logManager.WriteLog();
        }
    }
}
