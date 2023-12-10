using ArchitectProg.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesBadRequestAttribute()
    : ProducesResponseTypeAttribute(typeof(ErrorResult), StatusCodes.Status400BadRequest);