using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using yangxj96_serve_example.Common.Response;

namespace yangxj96_serve_example.Filter;

/// <summary>
/// 统一响应修改
/// </summary>
public class UniformResponseFilter : IAsyncResultFilter
{
    
    private readonly ILogger<UniformResponseFilter> _logger;
    
    private readonly UniformResponseExtraHelper  _extraHelper;

    public UniformResponseFilter(UniformResponseExtraHelper extraHelper,ILogger<UniformResponseFilter> logger)
    {
        _logger = logger;
        _extraHelper = extraHelper;
    }


    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        // 文件对象
        if (context.Result  is FileResult)
        {
            await next();
            return;
        }
        R<object> r;
        switch (context.Result)
        {
            // 失败请求
            case BadRequestObjectResult bror:
            {
                
                if (bror.Value is ValidationProblemDetails details)
                {
                    var error = details.Title + ";" + string.Join(";", details.Errors.Select(e => $"【{e.Key}:{string.Join(",", e.Value)}】"));
                    _logger.LogError(error);
                    r = R<object>.Failure(error);
                    break;
                }
                r = R<object>.Failure("未知异常");
                break;
            }
            // 空响应
            case EmptyResult:
                r = R<object>.Success();
                break;
            // json响应
            case JsonResult j:
                r = R<object>.Success(j);
                break;
            default:
                var obj = (ObjectResult)context.Result;
                if (obj.StatusCode is 200 or null)
                {
                    r = obj.Value == null ? R<object>.Success() : R<object>.Success(obj.Value);
                }
                else if (obj.Value is ProblemDetails { Title: not null } details)
                {
                    // if (obj.Value is ProblemDetails details && details.Title != null)
                    r = R<object>.Failure(details.Title);
                }
                else
                {
                    r = R<object>.Failure("请求异常");
                }
                context.Result = new ObjectResult(r);
                break;
        }
        r.Extra = _extraHelper.GetExtraData();
        context.Result = new ObjectResult(r);
        await next();
    }
}