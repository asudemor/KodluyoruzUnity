using System;

namespace csharp_interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya yazdım.");
        }
    }
}