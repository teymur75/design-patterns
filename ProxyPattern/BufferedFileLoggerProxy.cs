using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class BufferedFileLoggerProxy : ILogger
    {
        private readonly FileLogger _logger;
        private readonly int bufferSize;
        private List<string> logs;


        public void Log(string message)
        {
            
        }
    }
}
