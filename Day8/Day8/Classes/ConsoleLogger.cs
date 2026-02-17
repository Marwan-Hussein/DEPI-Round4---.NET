using Day8.Interfaces;
using System;
namespace Day8.Classes
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(){ Console.WriteLine("Logging from the CONSOLE..."); }
    }
}
