using System;

namespace csharp_interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazdım.");
        }
    }
}