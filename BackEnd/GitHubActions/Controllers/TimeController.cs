using Microsoft.AspNetCore.Mvc;

namespace GitHubActions.Controllers;

public class TimeController : ControllerBase
{
    [HttpGet]
    [Route("/WhatTime")]
    public string WhatTime()
    {
        return "Server date time is " + DateTime.Now;
    }
}