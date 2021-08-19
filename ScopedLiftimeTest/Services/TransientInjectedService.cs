using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class TransientInjectedService : ITransientInjectedService
    {
        private readonly ILogger<TransientInjectedService> _logger;

        public TransientInjectedService(ILogger<TransientInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("TransientInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
