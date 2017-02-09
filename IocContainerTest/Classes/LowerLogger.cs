using System;

namespace Ioc
{
    public class LowerLogger : ILogger
    {
        public void Log(string message) { Console.WriteLine(message.ToLower()); }
    }
}