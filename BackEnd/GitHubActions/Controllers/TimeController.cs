using Microsoft.AspNetCore.Mvc;

namespace GitHubActions.Controllers;

public class TimeController : ControllerBase
{
    [HttpGet]
    [Route("/WhatTime")]
    public DateTime WhatTime()
    {
        return DateTime.Now;
    }
}