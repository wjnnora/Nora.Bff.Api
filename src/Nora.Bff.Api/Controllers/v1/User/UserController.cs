using Microsoft.AspNetCore.Mvc;
using Nora.Bff.Api.Domain.Clients.v1.User.User;
using Nora.Bff.Api.Domain.Contracts.v1.Services.User;

namespace Nora.Bff.Api.Controllers.v1.User;

[ApiController]
[Route("api/v1/users")]
public sealed class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateUserRequest request)
    {
        await userService.CreateAsync(request);

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync([FromRoute] int id)
    {
        var response = await userService.GetAsync(id);

        return Ok(response);
    }
}