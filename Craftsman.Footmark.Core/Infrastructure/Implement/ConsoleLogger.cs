using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }
        public void LogCritical(string message)
        {
            Console.WriteLine($"[Critical]:{message}");
        }

        public void LogDebug(string message)
        {
            Console.WriteLine($"[Debug]:{message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"[Error]:{message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"[Info]:{message}");
        }

        public void LogTrace(string message)
        {
            Console.WriteLine($"[Trace]:{message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"[Warning]:{message}");
        }
    }
}
