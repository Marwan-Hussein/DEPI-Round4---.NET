using System;

namespace Day8.Interfaces
{
    internal interface ILogger
    {
        void Log(){ Console.WriteLine("Logging from interface..."); }
    }
}
