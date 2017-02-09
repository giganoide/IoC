using System;

namespace Ioc
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) { Console.WriteLine(message); }
    }
}