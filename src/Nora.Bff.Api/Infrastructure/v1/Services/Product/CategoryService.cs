using Nora.Bff.Api.Domain.Clients.v1.Product.Category;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

namespace Nora.Bff.Api.Infrastructure.v1.Services.Product;

public sealed class CategoryService(ICategoryClient categoryClient) : ICategoryService
{
    public Task CreateAsync(CreateCategoryRequest request)
        => categoryClient.CreateAsync(request);

    public Task<CategoryResponse> GetByIdAsync(int id)
        => categoryClient.GetByIdAsync(id);
}