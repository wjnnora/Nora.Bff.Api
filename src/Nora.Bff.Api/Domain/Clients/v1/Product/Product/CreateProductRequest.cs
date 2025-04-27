namespace Nora.Bff.Api.Domain.Clients.v1.Product.Product;

public sealed class CreateProductRequest
{
    public string Description { get; set; }
    public decimal Value { get; set; }
    public int CategoryId { get; set; }
}