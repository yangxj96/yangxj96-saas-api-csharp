using Microsoft.OpenApi.Extensions;

namespace yangxj96_serve_example.Common.Response;

public class R<T>
{
    public long Code { get; set; }

    public string? Msg { get; set; }

    public T? Data { get; set; }
    
    /// <summary>
    /// 额外的信息
    /// </summary>
    public dynamic? Extra { get; set; }

    /// <summary>
    /// 成功响应
    /// </summary>
    /// <returns>R</returns>
    public static R<T> Success() => new()
    {
        Code = 0,
        Msg = RStatus.Success.GetDisplayName()
    };

    /// <summary>
    /// 成功响应
    /// </summary>
    /// <param name="data">跟随返回的数据</param>
    /// <returns>R</returns>
    public static R<T> Success(T data) => new()
    {
        Code = RStatus.Success.GetHashCode(),
        Msg = RStatus.Success.GetDisplayName(),
        Data = data
    };

    /// <summary>
    /// 失败响应
    /// </summary>
    /// <returns>R</returns>
    public static R<T> Failure() => new()
    {
        Code = RStatus.Failure.GetHashCode(),
        Msg = RStatus.Failure.GetDisplayName(),
    };
    
    /// <summary>
    /// 失败响应
    /// </summary>
    /// <returns>R</returns>
    public static R<T> Failure(string error) => new()
    {
        Code = RStatus.Failure.GetHashCode(),
        Msg = error,
    };

    /// <summary>
    /// 失败定义
    /// </summary>
    /// <param name="status">状态</param>
    /// <returns>R</returns>
    public static R<T> Failure(RStatus status) => new()
    {
        Code = status.GetHashCode(),
        Msg = status.GetDisplayName()
    };
}