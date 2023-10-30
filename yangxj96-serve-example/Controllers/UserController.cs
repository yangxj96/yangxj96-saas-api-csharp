using Microsoft.AspNetCore.Mvc;
using yangxj96_serve_example.Common.Response;
using yangxj96_serve_example.Model;
using yangxj96_serve_example.Service;

namespace yangxj96_serve_example.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 日志记录
        /// </summary>
        private readonly ILogger<UserController> _logger;

        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        public User Created(User datum)
        {
            _logger.LogInformation("[UserController] 新增用户");
            return _userService.Created(datum);
        }

        [HttpGet("Page")]
        public List<User> Page()
        {
            _logger.LogInformation("[UserController] 分页查询");
            return _userService.Page();
        }

        [HttpGet("All")]
        public List<User> GetAll()
        {
            _logger.LogInformation("[UserController] 获取所有用户");
            return _userService.GetAll();
        }
    }
}