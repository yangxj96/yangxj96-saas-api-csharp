using Microsoft.AspNetCore.Mvc;
using Nacos.V2;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NacosController : ControllerBase
    {
        private readonly ILogger<NacosController> _logger;

        private readonly INacosNamingService _svc;

        public NacosController(ILogger<NacosController> logger, INacosNamingService svc)
        {
            _logger = logger;
            _svc = svc;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            _logger.LogInformation("nacos controller debug get");
            var instance = await _svc.SelectOneHealthyInstance("yangxj96-serve-example-csharp", "DEFAULT_GROUP");
            var host = $"{instance.Ip}:{instance.Port}";
            var baseUrl = $"http://{host}";
            if (string.IsNullOrEmpty(baseUrl))
            {
                return "empty";
            }

            using var client = new HttpClient();
            var result = await client.GetAsync($"{baseUrl}/api/Nacos");
            return await result.Content.ReadAsStringAsync();
        }
    }
}