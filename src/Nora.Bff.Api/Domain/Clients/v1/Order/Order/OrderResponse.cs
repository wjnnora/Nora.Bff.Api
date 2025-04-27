namespace Nora.Bff.Api.Domain.Clients.v1.Order.Order;

public sealed class OrderResponse
{
    public int Id { get; set; }
    public OrderCustomerResponse Customer { get; set; }
    public List<OrderOrderItemResponse> OrderItems { get; set; }
}