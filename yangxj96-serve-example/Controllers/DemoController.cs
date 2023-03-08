using Microsoft.AspNetCore.Mvc;
using yangxj96_serve_example.Model;
using yangxj96_serve_example.Repository;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<NacosController> _logger;

        private readonly IDemoRepository _repository;


        public DemoController(ILogger<NacosController> logger, IDemoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public Demo? Get(int id)
        {
            _logger.LogInformation($"获取单条数据,ID:{id}");
            return _repository.GetDemo(id);
        }

        [HttpGet("All")]
        public List<Demo> GetAll()
        {
            IEnumerable<Demo> demos = _repository.GetAllDemos();
            return (List<Demo>)_repository.GetAllDemos();
        }

        [HttpPost]
        public Demo Add(Demo param)
        {
            return _repository.Add(param);
        }

        [HttpDelete("{id}")]
        public Demo? Remove(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public Demo Update(Demo param)
        {
            return _repository.Update(param);
        }
    }
}