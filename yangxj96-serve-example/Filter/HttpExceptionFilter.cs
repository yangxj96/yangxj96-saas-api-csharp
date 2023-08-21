using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using yangxj96_serve_example.Common.Exception;
using yangxj96_serve_example.Common.Response;

namespace yangxj96_serve_example.Filter;

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
            DataInsertException   => R.FailureSpecify(RStatus.DataInsertFailure),
            DataDeletedException  => R.FailureSpecify(RStatus.DataDeleteFailure),
            DataUpdateException   => R.FailureSpecify(RStatus.DataUpdateFailure),
            DataQueryException    => R.FailureSpecify(RStatus.DataQueryFailure),
            DataExistException    => R.FailureSpecify(RStatus.DataExistFailure),
            DataNotExistException => R.FailureSpecify(RStatus.DataNotExistFailure),
            _ => R.Failure()
        };
        // 设置响应内容和响应状态等
        context.Result = new ObjectResult(result)
        {
            StatusCode = ((int)HttpStatusCode.BadGateway)
        };
    }
}