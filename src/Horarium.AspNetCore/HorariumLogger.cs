using System;
using Horarium.Interfaces;
using Microsoft.Extensions.Logging;

namespace Horarium.AspNetCore
{
    public class HorariumLogger : IHorariumLogger
    {
        private readonly ILogger<HorariumLogger> _logger;

        public HorariumLogger(ILogger<HorariumLogger> logger)
        {
            _logger = logger;
        }

        public void Debug(string msg)
        {
            _logger.LogDebug(msg);
        }

        public void Debug(Exception ex)
        {
            _logger.LogDebug(ex.Message + ex.StackTrace);
        }

        public void Error(Exception ex)
        {
            _logger.LogWarning(ex.Message + ex.StackTrace);
        }

        public void Error(string message, Exception ex)
        {
            _logger.LogWarning(message + ex.Message + ex.StackTrace);
        }
    }
}