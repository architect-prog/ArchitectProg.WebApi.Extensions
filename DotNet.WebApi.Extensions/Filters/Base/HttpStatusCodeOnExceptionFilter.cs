using DotNet.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNet.WebApi.Extensions.Filters.Base;

public class HttpStatusCodeOnExceptionFilter : IExceptionFilter
{
    private readonly int statusCode;
    private readonly Type[] exceptionTypes;

    public HttpStatusCodeOnExceptionFilter(int statusCode, params Type[] exceptionTypes)
    {
        this.statusCode = statusCode;
        this.exceptionTypes = exceptionTypes;
    }

    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        if (exceptionTypes.Any(x => x == exception.GetType()))
        {
            var response = new ErrorResult(statusCode, exception.Message);

            context.HttpContext.Response.StatusCode = statusCode;
            context.Result = new ObjectResult(response);
        }
    }
}