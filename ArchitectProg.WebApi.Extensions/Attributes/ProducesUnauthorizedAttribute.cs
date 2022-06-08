using ArchitectProg.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesUnauthorizedAttribute : ProducesResponseTypeAttribute
{
    public ProducesUnauthorizedAttribute()
        : base(typeof(ErrorResult), StatusCodes.Status401Unauthorized)
    {
    }
}