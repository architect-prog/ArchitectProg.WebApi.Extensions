using ArchitectProg.WebApi.Extensions.Filters.Base;
using Microsoft.AspNetCore.Http;

namespace ArchitectProg.WebApi.Extensions.Filters;

public class NotFoundOnExceptionFilter(params Type[] exceptionTypes)
    : HttpStatusCodeOnExceptionFilter(StatusCodes.Status404NotFound, exceptionTypes);