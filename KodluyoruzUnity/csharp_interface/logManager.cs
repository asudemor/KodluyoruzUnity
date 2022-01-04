using System;

namespace csharp_interface
{
    public class logManager
    {
        public ILogger _logger;
        public logManager(ILogger logger)
        {
            _logger = logger;
        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
