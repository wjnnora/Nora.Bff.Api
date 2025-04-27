using Microsoft.AspNetCore.Mvc;
using Nora.Bff.Api.Domain.Clients.v1.Product.Product;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

namespace Nora.Bff.Api.Controllers.v1.Product;

[ApiController]
[Route("api/v1/products")]
public sealed class ProductController(IProductService productService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateProductRequest request)
    {
        await productService.CreateAsync(request);

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        var response = await productService.GetByIdAsync(id);

        return Ok(response);
    }
}