using SqlSugar;
using yangxj96_serve_example.Common.Exception;
using yangxj96_serve_example.Model;
using yangxj96_serve_example.Utils;

namespace yangxj96_serve_example.Service.Impl;

public class UserService : DbContext<User>, IUserService
{
    private readonly ILogger<UserService> _logger;

    public UserService(ILogger<UserService> logger, IConfiguration configuration) : base(configuration)
    {
        _logger = logger;
    }

    public User Created(User datum)
    {
        _logger.LogInformation("[UserService] 创建用户");
        try
        {
            if (datum.Id < 0)
            {
                throw new DataExistException("[UserService] ID异常");
            }

            using var tran = Db.UseTran();
            var id = Db.Insertable(datum).ExecuteReturnSnowflakeId();
            tran.CommitTran();
            return SimpleDb.GetById(id);
        } catch (Exception e)
        {
            Db.RollbackTran();
            _logger.LogError("[UserService] 新增用户失败:{}", e.Message);
            throw new DataInsertException("[UserService] 新增用户失败," + e.Message);
        }
    }

    public bool DeletedById(long id)
    {
        _logger.LogInformation("[UserService] 根据ID删除用户,用户ID:{}", id);
        try
        {
            using var tran = Db.UseTran();
            var result = Db.Deleteable(new User { Id = id }).ExecuteCommandHasChange();
            tran.CommitTran();
            return result;
        } catch (Exception e)
        {
            Db.RollbackTran();
            _logger.LogError("[UserService] 根据ID删除用户失败:{}", e.Message);
            throw new DataDeletedException("[UserService] 根据ID删除用户失败," + e.Message);
        }
    }

    public User? Updated(User datum)
    {
        _logger.LogInformation("[UserService] 更新用户,用户ID:{}", datum.Id);

        try
        {
            if (datum.Id < 0)
            {
                throw new DataNotExistException("[UserService] 数据不存在");
            }

            using var tran = Db.UseTran();
            var result = Db.Updateable(datum).ExecuteCommandHasChange();
            tran.CommitTran();
            return result ? SimpleDb.GetById(datum.Id) : null;
        } catch (Exception e)
        {
            Db.RollbackTran();
            _logger.LogError("[UserService] 更新用户失败:{}", e.Message);
            throw new DataUpdateException("[UserService] 更新用户失败," + e.Message);
        }
    }

    public List<User> GetAll()
    {
        _logger.LogInformation("[UserService] 获取所有用户");
        try
        {
            return SimpleDb.GetList();
        } catch (Exception e)
        {
            _logger.LogError("[UserService] 获取所有用户失败:{}", e.Message);
            throw new DataQueryException("[UserService] 获取所有用户失败");
        }
    }

    public List<User> Page()
    {
        _logger.LogInformation("[UserService] 分页查询");
        try
        {
            var page = new PageModel
            {
                PageSize = 10,
                PageIndex = 1
            };
            var conditional = new List<IConditionalModel>();
            return SimpleDb.GetPageList(conditional,page);
        }
        catch (Exception e)
        {
            _logger.LogError("[UserService] 分页查询失败:{}", e.Message);
            throw new DataQueryException("[UserService] 分页查询失败");
        }
    }
}