using Craftsman.Footmark.Core.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace Craftsman.Footmark.Core.Infrastructure.Implement
{
    public class XUnitLogger : ILogger
    {
        private ITestOutputHelper _output;
        public XUnitLogger(ITestOutputHelper output)
        {
            _output = output;
        }

        public XUnitLogger()
        {
        }
        public void LogCritical(string message)
        {
            _output.WriteLine($"[Critical]:{message}");
        }

        public void LogDebug(string message)
        {
            _output.WriteLine($"[Debug]:{message}");
        }

        public void LogError(string message)
        {
            _output.WriteLine($"[Error]:{message}");
        }

        public void LogInformation(string message)
        {
            _output.WriteLine($"[Info]:{message}");
        }

        public void LogTrace(string message)
        {
            _output.WriteLine($"[Trace]:{message}");
        }

        public void LogWarning(string message)
        {
            _output.WriteLine($"[Warning]:{message}");
        }
    }
}
