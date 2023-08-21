using yangxj96_serve_example.Model;
using yangxj96_serve_example.Utils;

namespace yangxj96_serve_example.Service.Impl
{
    public class DemoService : DbContext<Demo>, IDemoService
    {
        private readonly ILogger<DemoService> _logger;

        public DemoService(ILogger<DemoService> logger)
        {
            _logger = logger;
        }
    }
}