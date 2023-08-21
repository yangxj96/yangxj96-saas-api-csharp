using Microsoft.OpenApi.Extensions;

namespace yangxj96_serve_example.Common.Response;

public class R
{
    public long Code { get; set; } = 0L;

    public string Msg { get; set; } = "success";

    public object? Data { get; set; }

    /// <summary>
    /// 成功响应
    /// </summary>
    /// <returns>R</returns>
    public static R Success()
    {
        return new R
        {
            Code = 0,
            Msg = RStatus.Success.GetDisplayName()
        };
    }

    /// <summary>
    /// 成功响应
    /// </summary>
    /// <param name="data">跟随返回的数据</param>
    /// <returns>R</returns>
    public static R Success(object data)
    {
        return new R
        {
            Code = 0,
            Msg = RStatus.Success.GetDisplayName(),
            Data = data
        };
    }

    /// <summary>
    /// 失败响应
    /// </summary>
    /// <returns>R</returns>
    public static R Failure()
    {
        return new R
        {
            Code = -1,
            Msg = RStatus.Failure.GetDisplayName(),
        };
    }
}