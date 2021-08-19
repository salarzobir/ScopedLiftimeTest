using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class TransientNotInjectedService : ITransientNotInjectedService
    {
        private readonly ILogger<TransientNotInjectedService> _logger;

        public TransientNotInjectedService(ILogger<TransientNotInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("TransientNotInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
