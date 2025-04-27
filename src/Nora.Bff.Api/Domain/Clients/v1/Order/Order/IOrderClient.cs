using Refit;

namespace Nora.Bff.Api.Domain.Clients.v1.Order.Order;

public interface IOrderClient
{
    [Post("")]
    Task CreateAsync([Body] CreateOrderRequest request);

    [Get("/{id}")]
    Task<OrderResponse> GetByIdAsync(int id);
}