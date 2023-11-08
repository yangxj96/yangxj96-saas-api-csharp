namespace Yangxj96.Serve.Common.Response;

public static class RStatus
{
    public readonly struct ResponseStatus
    {
        public int Code { get; }
        public string Msg { get; }

        public ResponseStatus(int code, string msg)
        {
            Code = code;
            Msg = msg;
        }

        public override string ToString() => $"code:{Code},msg:{Msg}";
    }

    public static readonly ResponseStatus Failure = new(-1, "请求失败");
    public static readonly ResponseStatus Success = new(0, "请求成功");

    public static readonly ResponseStatus DataExistFailure    = new(0, "数据已存在");
    public static readonly ResponseStatus DataNotExistFailure = new(0, "数据不存在");
    public static readonly ResponseStatus DataInsertFailure   = new(0, "数据插入失败");
    public static readonly ResponseStatus DataDeleteFailure   = new(0, "数据删除失败");
    public static readonly ResponseStatus DataUpdateFailure   = new(0, "数据更新失败");
    public static readonly ResponseStatus DataQueryFailure    = new(0, "数据查询失败");
}