namespace Yangxj96.Serve.Common.Response;

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
        Code = RStatus.Success.Code,
        Msg = RStatus.Success.Msg
    };


    /// <summary>
    /// 成功响应
    /// </summary>
    /// <param name="data">跟随返回的数据</param>
    /// <returns>R</returns>
    public static R<T> Success(T data) => new()
    {
        Code = RStatus.Success.Code,
        Msg = RStatus.Success.Msg,
        Data = data
    };

    /// <summary>
    /// 失败响应
    /// </summary>
    /// <returns>R</returns>
    public static R<T> Failure() => new()
    {
        Code = RStatus.Failure.Code,
        Msg = RStatus.Failure.Msg
    };

    /// <summary>
    /// 失败响应
    /// </summary>
    /// <returns>R</returns>
    public static R<T> Failure(string error) => new()
    {
        Code = RStatus.Failure.Code,
        Msg = error,
    };

    /// <summary>
    /// 失败定义
    /// </summary>
    /// <param name="status">状态</param>
    /// <returns>R</returns>
    public static R<T> Failure(RStatus.ResponseStatus status) => new()
    {
        Code = status.Code,
        Msg = status.Msg
    };
}