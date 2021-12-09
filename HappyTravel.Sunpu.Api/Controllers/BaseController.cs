using CSharpFunctionalExtensions;
using HappyTravel.Sunpu.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;

namespace HappyTravel.Sunpu.Api.Controllers;

public class BaseController : ControllerBase
{
    protected IActionResult NoContentOrBadRequest(Result model)
    {
        var (_, isFailure, error) = model;
        if (isFailure)
            return BadRequest(ProblemDetailsBuilder.Build(error));

        return NoContent();
    }


    protected IActionResult OkOrBadRequest<T>(Result<T> model)
    {
        var (_, isFailure, response, error) = model;
        if (isFailure)
            return BadRequest(ProblemDetailsBuilder.Build(error));

        return Ok(response);
    }
}
