using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Identity.Api.Controllers
{
    [ApiController, Authorize]
    [Route("[controller]")]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public IdentityController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogWarning("HAHAH");
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
