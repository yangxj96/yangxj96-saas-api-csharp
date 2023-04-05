using Microsoft.AspNetCore.Mvc;
using yangxj96_serve_example.Remote;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NacosController : ControllerBase
    {
        private readonly ILogger<NacosController> _logger;

        private readonly SystemRemote _remote;

        public NacosController(ILogger<NacosController> logger, SystemRemote remote)
        {
            _logger = logger;
            _remote = remote;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            _logger.LogInformation("nacos controller debug get");
            return await _remote.Demo();
        }
    }
}