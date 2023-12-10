using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectProg.WebApi.Extensions.Attributes;

public class ProducesCreatedAttribute(Type responseType)
    : ProducesResponseTypeAttribute(responseType, StatusCodes.Status201Created);