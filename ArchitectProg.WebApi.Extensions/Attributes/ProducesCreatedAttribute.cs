using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesCreatedAttribute : ProducesResponseTypeAttribute
{
    public ProducesCreatedAttribute(Type responseType)
        : base(responseType, StatusCodes.Status201Created)
    {
    }
}