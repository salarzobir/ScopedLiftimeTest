using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class SingletonNotInjectedService : ISingletonNotInjectedService
    {
        private readonly ILogger<SingletonNotInjectedService> _logger;

        public SingletonNotInjectedService(ILogger<SingletonNotInjectedService> logger)
        {
            _logger = logger;
            _logger.LogInformation("SingletonNotInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
