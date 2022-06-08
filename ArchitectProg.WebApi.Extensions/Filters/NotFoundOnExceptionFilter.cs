using ArchitectProg.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace ArchitectProg.WebApi.Extensions.Filters;

public class NotFoundOnExceptionFilter : HttpStatusCodeOnExceptionFilter
{
    public NotFoundOnExceptionFilter(params Type[] exceptionTypes)
        : base(StatusCodes.Status404NotFound, exceptionTypes)
    {
    }
}