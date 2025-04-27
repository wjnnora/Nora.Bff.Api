using Microsoft.AspNetCore.Mvc;
using Nora.Bff.Api.Domain.Clients.v1.Order.Order;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Order;

namespace Nora.Bff.Api.Controllers.v1.Order;

[ApiController]
[Route("api/v1/orders")]
public sealed class OrderController(IOrderService orderService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateOrderRequest request)
    {
        await orderService.CreateAsync(request);

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        var response = await orderService.GetByIdAsync(id);

        return Ok(response);
    }
}