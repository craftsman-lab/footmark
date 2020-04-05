using System;
using System.Collections.Generic;
using System.Text;

namespace Craftsman.Footmark.Core.Infrastructure.Abstraction
{
    public interface ILogger
    {
        void LogTrace(string message);
        void LogDebug(string message);
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogCritical(string message);
    }
}
