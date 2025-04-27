using Nora.Bff.Api.Domain.Clients.v1.Product.Category;

namespace Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

public interface ICategoryService
{
    Task CreateAsync(CreateCategoryRequest request);
    Task<CategoryResponse> GetByIdAsync(int id);
}