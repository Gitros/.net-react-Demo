﻿using Application.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ProfilesController : BaseApiController
{
    [HttpGet("{username}")]
    public async Task<IActionResult> GetProfile(string username) 
        => HandleResult(await Mediator.Send(new Details.Query { Username = username }));

    [HttpPut]
    public async Task<IActionResult> EditProfile(EditProfile.Command command) 
        => HandleResult(await Mediator.Send(command));

    [HttpGet("{username}/activities")]
    public async Task<IActionResult> GetUserActivities(string username, string predicate) 
        => HandleResult(await Mediator.Send(new ListActivities.Query 
            { Username = username, Predicate = predicate}));
}
