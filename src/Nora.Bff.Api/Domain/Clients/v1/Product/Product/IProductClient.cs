using Refit;

namespace Nora.Bff.Api.Domain.Clients.v1.Product.Product;

public interface IProductClient
{
    [Post("")]
    Task CreateAsync([Body] CreateProductRequest request);

    [Get("/{id}")]
    Task<ProductResponse> GetByIdAsync(int id);
}