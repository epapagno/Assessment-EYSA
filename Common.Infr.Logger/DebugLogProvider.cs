using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Infr.Logger
{
    public class DebugLogProvider : ILoggerProvider
    {
        private ILogger logger;
        public ILogger CreateLogger(string categoryName)
        {
            if (logger == null)
                logger = new DebugLogger();

            return logger;
        }

        public void Dispose() { }
    }
}
