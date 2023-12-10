using ArchitectProg.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace ArchitectProg.WebApi.Extensions.Filters;

public class BadRequestOnExceptionFilter(params Type[] exceptionTypes)
    : HttpStatusCodeOnExceptionFilter(StatusCodes.Status400BadRequest, exceptionTypes);