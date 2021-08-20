using Microsoft.Extensions.Logging;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Services
{
    public class AnotherInjectedService : IAnotherInjectedService
    {
        private readonly ILogger<AnotherInjectedService> _logger;
        private readonly IScopedInjectedService _scopedInjectedService;
        private readonly ITransientInjectedService _transientInjectedService;

        public AnotherInjectedService(ILogger<AnotherInjectedService> logger, IScopedInjectedService scopedInjectedService, ITransientInjectedService transientInjectedService)
        {
            _logger = logger;
            _scopedInjectedService = scopedInjectedService;
            _transientInjectedService = transientInjectedService;
            _logger.LogInformation("AnotherInjectedService is created");
        }

        public int Sum(int a, int b)
        {
            _ = _scopedInjectedService.Sum(a, b);
            _ = _transientInjectedService.Sum(a, b);
            return a + b;
        }
    }
}
