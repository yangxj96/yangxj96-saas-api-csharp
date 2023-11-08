using Nacos.V2;

namespace Yangxj96.Serve.Example.Remote
{
    public class SystemRemote
    {
        private readonly ILogger<SystemRemote> _logger;

        private readonly INacosNamingService _svc;

        public SystemRemote(ILogger<SystemRemote> logger, INacosNamingService svc)
        {
            _logger = logger;
            _svc = svc;
        }

        public async Task<string> Demo()
        {
            _logger.LogInformation("SystemRemote Demo");
            var instance = await _svc.SelectOneHealthyInstance("Yangxj96.Serve.Example-csharp", "DEFAULT_GROUP");
            var host = $"{instance.Ip}:{instance.Port}";
            var baseUrl = $"http://{host}";
            if (string.IsNullOrEmpty(baseUrl))
            {
                return "empty";
            }

            using var client = new HttpClient();
            var result = await client.GetAsync($"{baseUrl}/Demo/All");
            return await result.Content.ReadAsStringAsync();
        }
    }
}