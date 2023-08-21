using System.ComponentModel;

namespace yangxj96_serve_example.Common.Response;

public enum RStatus
{
    [Description("未知异常")] Failure = -1,
    [Description("操作成功")] Success,

    [Description("数据已存在")] DataExistFailure,
    [Description("数据不存在")] DataNotExistFailure,

    [Description("数据插入失败")] DataInsertFailure,
    [Description("数据删除失败")] DataDeleteFailure,
    [Description("数据更新失败")] DataUpdateFailure,
    [Description("数据查询失败")] DataQueryFailure,
}