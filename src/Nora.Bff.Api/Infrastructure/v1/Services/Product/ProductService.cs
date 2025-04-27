using Nora.Bff.Api.Domain.Clients.v1.Product.Product;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;

namespace Nora.Bff.Api.Infrastructure.v1.Services.Product;

public sealed class ProductService(IProductClient productClient) : IProductService
{
    public async Task CreateAsync(CreateProductRequest request)
        => await productClient.CreateAsync(request);

    public async Task<ProductResponse> GetByIdAsync(int id)
        => await productClient.GetByIdAsync(id);
}