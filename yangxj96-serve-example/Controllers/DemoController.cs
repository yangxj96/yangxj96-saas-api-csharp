using Microsoft.AspNetCore.Mvc;
using yangxj96_serve_example.Model;
using yangxj96_serve_example.Remote;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<NacosController> _logger;

        private readonly SystemRemote _systemRemote;

        public DemoController(ILogger<NacosController> logger,SystemRemote systemRemote)
        {
            _logger = logger;
            _systemRemote = systemRemote;
        }

        [HttpGet]
        public List<Demo> Get()
        {
            _logger.LogInformation($"demo controller get");
            var list = new List<Demo>();

            for (int i = 0; i < 10; i++)
            {
                var datum = new Demo
                {
                    Id = i,
                    Name = $"username-{i}",
                    Description = $"description-{i}",
                    CreatedDate = DateTime.Now,
                };
                list.Add(datum);
            }

            return list;
        }

        [HttpPost]
        public void Post(Demo param)
        {
            _logger.LogInformation($"post param:{param.ToString()}");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogInformation($"delete id:{id}");
        }

        [HttpPut]
        public void Put(Demo param)
        {
            _logger.LogInformation($"put param:{param.ToString()}");
        }

        [HttpGet("GetDemo")]
        public async Task<string> GetDemo()
        {
            _logger.LogInformation("🎨 输出");
            return await _systemRemote.Demo();
        }
    }
}
