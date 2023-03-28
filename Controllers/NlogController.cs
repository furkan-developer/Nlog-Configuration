using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nlog_Configuration.Controllers
{
    [Route("api/nlog")]
    [ApiController]
    public class NlogController : ControllerBase
    {
        private readonly ILogger<NlogController> _logger;

        public NlogController(ILogger<NlogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("NLOG MEKANİZMASI");
            return NoContent();
        }
    }
}
