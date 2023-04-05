using yangxj96_serve_example.Model;

namespace yangxj96_serve_example.Repository
{
    public interface IDemoRepository
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="param">实体参数</param>
        /// <returns>新增的信息</returns>
        Task<Demo?> Add(Demo param);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="param">实体参数</param>
        /// <returns>更新的信息</returns>
        Task<Demo?> Update(Demo param);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">数据id</param>
        /// <returns>删除的实体信息</returns>
        Task<Demo?> Delete(int id);

        /// <summary>
        /// 根据ID获取信息
        /// </summary>
        /// <param name="id">数据id</param>
        /// <returns>获取的数据信息</returns>
        Task<Demo?> GetDemo(int id);

        /// <summary>
        /// 获取全部信息
        /// </summary>
        /// <returns>全部信息</returns>
        Task<IEnumerable<Demo?>> GetAllDemos();
    }
}