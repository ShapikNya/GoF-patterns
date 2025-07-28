using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Classes
{
    public class Logger
    {
        private readonly StringBuilder _data = new StringBuilder();

        private static Logger _instance;

        private static readonly object _lock = new object();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Logger();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            _data.AppendLine($"[{DateTime.Now}] {message}");
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
