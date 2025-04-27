using Nora.Bff.Api.Domain.Clients.v1.Product.Product;

namespace Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

public interface IProductService
{
    Task CreateAsync(CreateProductRequest request);
    Task<ProductResponse> GetByIdAsync(int id);
}