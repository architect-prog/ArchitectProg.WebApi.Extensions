using ArchitectProg.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace ArchitectProg.WebApi.Extensions.Filters;

public class BadRequestOnExceptionFilter : HttpStatusCodeOnExceptionFilter
{
    public BadRequestOnExceptionFilter(params Type[] exceptionTypes)
        : base(StatusCodes.Status400BadRequest, exceptionTypes)
    {
    }
}