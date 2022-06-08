using ArchitectProg.WebApi.Extensions.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesNotFoundAttribute : ProducesResponseTypeAttribute
{
    public ProducesNotFoundAttribute()
        : base(typeof(ErrorResult), StatusCodes.Status404NotFound)
    {
    }
}