using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class ScopedInjectedService : IScopedInjectedService
    {
        private readonly ILogger<ScopedInjectedService> _logger;

        public ScopedInjectedService(ILogger<ScopedInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("ScopedInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
