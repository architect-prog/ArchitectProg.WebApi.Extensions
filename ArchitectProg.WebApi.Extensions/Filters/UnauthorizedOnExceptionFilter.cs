using ArchitectProg.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace ArchitectProg.WebApi.Extensions.Filters;

public class UnauthorizedOnExceptionFilter(params Type[] exceptionTypes)
    : HttpStatusCodeOnExceptionFilter(StatusCodes.Status401Unauthorized, exceptionTypes);