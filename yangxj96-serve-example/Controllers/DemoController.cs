using Microsoft.AspNetCore.Mvc;
using yangxj96_serve_example.Model;
using yangxj96_serve_example.Repository;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        /// <summary>
        /// 日志记录
        /// </summary>
        private readonly ILogger<NacosController> _logger;

        /// <summary>
        /// ORM层操作
        /// </summary>
        private readonly IDemoRepository _repository;

        public DemoController(ILogger<NacosController> logger, IDemoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        /// <summary>
        /// 根据id查询数据
        /// </summary>
        /// <param name="id">数据id</param>
        /// <returns>符合条件的数据</returns>
        [HttpGet]
        public async Task<Demo?> Get(int id)
        {
            _logger.LogInformation($"获取单条数据,ID:{id}");
            return await _repository.GetDemo(id);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>数据库中的所有数据</returns>
        [HttpGet("All")]
        public async Task<IEnumerable<Demo?>> GetAll()
        {
            _logger.LogInformation($"获取所有数据");
            return await _repository.GetAllDemos();
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="param">参数</param>
        /// <returns>成功响应新的实体,失败响应null</returns>
        [HttpPost]
        public async Task<Demo?> Add(Demo param)
        {
            _logger.LogInformation($"添加一条数据");
            return await _repository.Add(param);
        }

        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <param name="id">数据id</param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<Demo?> Remove(int id)
        {
            return await _repository.Delete(id);
        }

        /// <summary>
        /// 数据更新
        /// </summary>
        /// <param name="param">实体参数</param>
        /// <returns>成功响应新的实体,失败响应null</returns>
        [HttpPut]
        public async Task<Demo?> Update(Demo param)
        {
            return await _repository.Update(param);
        }
    }
}