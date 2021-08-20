using Microsoft.AspNetCore.Mvc;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISingletonInjectedService _singletonInjectedService;
        private readonly IScopedInjectedService _scopedInjectedService;
        private readonly ITransientInjectedService _transientInjectedService;
        private readonly IAnotherInjectedService _anotherInjectedService;

        public WeatherForecastController(ISingletonInjectedService singletonInjectedService, IScopedInjectedService scopedInjectedService, ITransientInjectedService transientInjectedService, IAnotherInjectedService anotherInjectedService)
        {
            _singletonInjectedService = singletonInjectedService;
            _scopedInjectedService = scopedInjectedService;
            _transientInjectedService = transientInjectedService;
            _anotherInjectedService = anotherInjectedService;
        }

        [HttpGet]
        public int Get()
        {
            return _scopedInjectedService.Sum(_transientInjectedService.Sum(_singletonInjectedService.Sum(_anotherInjectedService.Sum(1, 2), 3), 4), 5);
        }
    }
}
