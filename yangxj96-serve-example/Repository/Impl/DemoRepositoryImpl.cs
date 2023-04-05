using SqlSugar;
using yangxj96_serve_example.Model;

namespace yangxj96_serve_example.Repository.Impl
{
    public class DemoRepositoryImpl : IDemoRepository
    {
        private readonly ILogger<DemoRepositoryImpl> _logger;

        private readonly ISqlSugarClient _db;

        public DemoRepositoryImpl(ILogger<DemoRepositoryImpl> logger, ISqlSugarClient db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<Demo?> Add(Demo param)
        {
            _logger.LogInformation($"添加一条数据");
            return await _db.Insertable<Demo>(param).ExecuteReturnEntityAsync();
        }

        public async Task<Demo?> Update(Demo param)
        {
            if (await _db.Updateable<Demo>(param).ExecuteCommandHasChangeAsync())
            {
                return param;
            }

            return null;
        }

        public async Task<Demo?> Delete(int id)
        {
            var datum = await _db.Queryable<Demo>().Where(i => i.Id == id).FirstAsync();
            if (datum == null)
            {
                return null;
            }

            if (await _db.Deleteable<Demo>().Where(i => i.Id == id).ExecuteCommandHasChangeAsync())
            {
                return datum;
            }

            return null;
        }

        public async Task<Demo?> GetDemo(int id)
        {
            _logger.LogInformation($"获取单条数据,ID:{id}");
            return await _db.Queryable<Demo>()
                .Where(it => it.Id == id)
                .FirstAsync();
        }

        public async Task<IEnumerable<Demo?>> GetAllDemos()
        {
            _logger.LogInformation($"获取所有数据");
            return await _db.Queryable<Demo>().ToListAsync();
        }
    }
}