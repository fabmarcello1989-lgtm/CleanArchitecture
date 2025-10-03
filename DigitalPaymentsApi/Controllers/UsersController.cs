using DigitalPaymentsApi.Features.Users.Commands;
using DigitalPaymentsApi.Features.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPaymentsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<User>> Create(CreateUser command)
    {
        var user = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetAll), new { id = user.Id }, user);
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAll()
    {
        var users = await _mediator.Send(new GetAllUsers());
        return Ok(users);
    }

}