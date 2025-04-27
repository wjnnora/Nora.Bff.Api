using Microsoft.AspNetCore.Mvc;
using Nora.Bff.Api.Domain.Clients.v1.Product.Category;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

namespace Nora.Bff.Api.Controllers.v1.Product;

[ApiController]
[Route("api/v1/categories")]
public sealed class CategoryController(ICategoryService categoryService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCategoryRequest request)
    {
        await categoryService.CreateAsync(request);

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        var response = await categoryService.GetByIdAsync(id);

        return Ok(response);
    }
}