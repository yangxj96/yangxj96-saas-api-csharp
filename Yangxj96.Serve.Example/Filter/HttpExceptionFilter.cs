using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Yangxj96.Serve.Common.Exception;
using Yangxj96.Serve.Common.Response;

namespace Yangxj96.Serve.Example.Filter;

/// <summary>
/// 异常处理
/// </summary>
public class HttpExceptionFilter : IActionFilter, IOrderedFilter
{
    public int Order => int.MaxValue - 10;

    public void OnActionExecuting(ActionExecutingContext context)
    {
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // 如果没异常,则直接返回 跳过这个过滤器
        if (context.Exception == null) return;
        // 设置异常处理在这里
        context.ExceptionHandled = true;
        // 根据异常类型进行设置响应内容
        var result = context.Exception switch
        {
            DataInsertException   => R<object>.Failure(RStatus.DataInsertFailure),
            DataDeletedException  => R<object>.Failure(RStatus.DataDeleteFailure),
            DataUpdateException   => R<object>.Failure(RStatus.DataUpdateFailure),
            DataQueryException    => R<object>.Failure(RStatus.DataQueryFailure),
            DataExistException    => R<object>.Failure(RStatus.DataExistFailure),
            DataNotExistException => R<object>.Failure(RStatus.DataNotExistFailure),
            _ => R<object>.Failure()
        };
        // 设置响应内容和响应状态等
        context.Result = new ObjectResult(result)
        {
            StatusCode = ((int)HttpStatusCode.BadGateway)
        };
    }
}