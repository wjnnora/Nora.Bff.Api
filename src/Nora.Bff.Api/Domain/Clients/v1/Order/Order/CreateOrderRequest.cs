using Refit;

namespace Nora.Bff.Api.Domain.Clients.v1.Order.Order;

public sealed class CreateOrderRequest
{
    public int UserId { get; set; }
    [Query(CollectionFormat.Multi)]
    public List<int> ProductIds { get; set; }
}