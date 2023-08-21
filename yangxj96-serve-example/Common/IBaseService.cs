namespace yangxj96_serve_example.Common;

/// <summary>
/// 基础service类
/// </summary>
public interface IBaseService<T>
{
    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="datum">实体</param>
    /// <returns>创建成功返回相应的实体,失败返回null</returns>
    T Created(T datum);

    /// <summary>
    /// 根据ID删除
    /// </summary>
    /// <param name="id">Id</param>
    /// <returns>是否删除成功</returns>
    bool DeletedById(long id);

    /// <summary>
    /// 根据ID更新数据
    /// </summary>
    /// <param name="datum">实体,ID字段必须存在</param>
    /// <returns>成功相应修改的实体,失败返回null</returns>
    T? Updated(T datum);

    /// <summary>
    /// 获取所有数据
    /// </summary>
    /// <returns>数据列表</returns>
    List<T> GetAll();
}