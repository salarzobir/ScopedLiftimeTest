using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class ScopedNotInjectedService : IScopedNotInjectedService
    {
        private readonly ILogger<ScopedNotInjectedService> _logger;

        public ScopedNotInjectedService(ILogger<ScopedNotInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("ScopedNotInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
