using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesNoContentAttribute()
    : ProducesResponseTypeAttribute(StatusCodes.Status204NoContent);