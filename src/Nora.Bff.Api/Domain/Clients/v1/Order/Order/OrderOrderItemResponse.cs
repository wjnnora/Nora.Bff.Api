namespace Nora.Bff.Api.Domain.Clients.v1.Order.Order;

public sealed class OrderOrderItemResponse
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }
}