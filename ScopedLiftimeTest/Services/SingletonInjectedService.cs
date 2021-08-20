using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class SingletonInjectedService : ISingletonInjectedService
    {
        private readonly ILogger<SingletonInjectedService> _logger;

        public SingletonInjectedService(ILogger<SingletonInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("SingletonInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
