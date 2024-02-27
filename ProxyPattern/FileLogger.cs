using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            message = $"[{DateTime.Now.Date}] - {message}";
            File.AppendAllText( "message.log", message);
        }
    }
}
