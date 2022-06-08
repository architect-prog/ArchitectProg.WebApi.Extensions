using ArchitectProg.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesBadRequestAttribute : ProducesResponseTypeAttribute
{
    public ProducesBadRequestAttribute()
        : base(typeof(ErrorResult), StatusCodes.Status400BadRequest)
    {
    }
}