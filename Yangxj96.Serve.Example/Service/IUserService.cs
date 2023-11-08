using Yangxj96.Serve.Common.Base;
using Yangxj96.Serve.Example.Model;

namespace Yangxj96.Serve.Example.Service;

public interface IUserService : IBaseService<User>
{
    /// <summary>
    /// 分页查询
    /// </summary>
    List<User> Page();
}