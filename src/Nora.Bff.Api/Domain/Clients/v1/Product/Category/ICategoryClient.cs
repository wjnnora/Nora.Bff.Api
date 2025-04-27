using Refit;

namespace Nora.Bff.Api.Domain.Clients.v1.Product.Category;

public interface ICategoryClient
{
    [Post("")]
    Task CreateAsync([Body] CreateCategoryRequest request);

    [Get("/{id}")]
    Task<CategoryResponse> GetByIdAsync(int id);
}