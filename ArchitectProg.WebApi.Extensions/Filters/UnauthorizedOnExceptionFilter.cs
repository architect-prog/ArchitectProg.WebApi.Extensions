using DotNet.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace DotNet.WebApi.Extensions.Filters;

public class UnauthorizedOnExceptionFilter : HttpStatusCodeOnExceptionFilter
{
    public UnauthorizedOnExceptionFilter(params Type[] exceptionTypes)
        : base(StatusCodes.Status401Unauthorized, exceptionTypes)
    {
    }
}