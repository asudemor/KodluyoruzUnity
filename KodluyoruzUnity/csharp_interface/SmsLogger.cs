using System;

namespace csharp_interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SMS olarak log yazar.");
        }
    }
}