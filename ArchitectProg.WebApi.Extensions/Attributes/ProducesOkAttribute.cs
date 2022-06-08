using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesOkAttribute : ProducesResponseTypeAttribute
{
    public ProducesOkAttribute()
        : base(StatusCodes.Status200OK)
    {
    }

    public ProducesOkAttribute(Type responseType)
        : base(responseType, StatusCodes.Status200OK)
    {
    }
}