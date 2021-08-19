using System;
using Microsoft.AspNetCore.Mvc;
using ScopedLiftimeTest.Interfaces;

namespace ScopedLiftimeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IScopedInjectedService _scopedInjectedService;
        private readonly ITransientInjectedService _transientInjectedService;
        private readonly IServiceProvider _serviceProvider;

        public WeatherForecastController(IScopedInjectedService scopedInjectedService, ITransientInjectedService transientInjectedService, IServiceProvider serviceProvider)
        {
            _scopedInjectedService = scopedInjectedService;
            _transientInjectedService = transientInjectedService;
            _serviceProvider = serviceProvider;
        }

        [HttpGet]
        public int Get()
        {
            return _scopedInjectedService.Sum(_transientInjectedService.Sum(1, 2), 3);
        }
    }
}
