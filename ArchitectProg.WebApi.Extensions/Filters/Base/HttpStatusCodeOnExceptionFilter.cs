using ArchitectProg.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ArchitectProg.WebApi.Extensions.Filters.Base;

public class HttpStatusCodeOnExceptionFilter(int statusCode, params Type[] exceptionTypes) : IExceptionFilter
{
    private readonly int statusCode = statusCode;
    private readonly Type[] exceptionTypes = exceptionTypes;

    public virtual void OnException(ExceptionContext context)
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