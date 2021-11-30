﻿using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;

namespace HappyTravel.Sunpu.Api.Controllers;

public class BaseController : ControllerBase
{
    protected static string LanguageCode => CultureInfo.CurrentCulture.Name;

    protected IActionResult BadRequestWithProblemDetails(string details)
        => BadRequest(new ProblemDetails
        {
            Detail = details,
            Status = (int)HttpStatusCode.BadRequest
        });
}
