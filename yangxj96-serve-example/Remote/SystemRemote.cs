using Nacos.V2;

namespace yangxj96_serve_example.Remote
{
    public class SystemRemote
    {
        private readonly ILogger<SystemRemote> _logger;

        private readonly INacosNamingService _svc;

        public SystemRemote(ILogger<SystemRemote> logger,INacosNamingService svc) {
            this._logger = logger;
            this._svc = svc;
        }

        public async Task<String> Demo()
        {
            _logger.LogInformation("SystemRemote Demo");
            var instance = await _svc.SelectOneHealthyInstance("yangxj96-serve-example-csharp", "DEFAULT_GROUP");
            var host = $"{instance.Ip}:{instance.Port}";
            var baseUrl = $"http://{host}";
            if (string.IsNullOrEmpty(baseUrl))
            {
                return "empty";
            }
            using var client = new HttpClient();
            var result = await client.GetAsync($"{baseUrl}/Demo");
            return await result.Content.ReadAsStringAsync();
        }

    }
}
