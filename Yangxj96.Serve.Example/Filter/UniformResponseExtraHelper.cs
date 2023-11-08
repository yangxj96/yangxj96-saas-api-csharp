namespace Yangxj96.Serve.Example.Filter;

public class UniformResponseExtraHelper
{
    private readonly Dictionary<string, object> _extraData;
    
    public UniformResponseExtraHelper()
    {
        _extraData = new Dictionary<string, object>();
    }
    
    /// <summary>
    /// 添加一个额外的数据
    /// </summary>
    /// <param name="name"></param>
    /// <param name="data"></param>
    public void Add(string name, object data) => _extraData.TryAdd(name, data);

    /// <summary>
    /// 获取额外的数据
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, object>? GetExtraData() => _extraData.Any() ? _extraData : null;
}