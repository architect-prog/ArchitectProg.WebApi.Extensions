using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.WebApi.Extensions.Attributes;

public class ProducesCreatedAttribute : ProducesResponseTypeAttribute
{
    public ProducesCreatedAttribute(Type responseType)
        : base(responseType, StatusCodes.Status201Created)
    {
    }
}