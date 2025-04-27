using Nora.Bff.Api.Domain.Clients.v1.Order.Order;

namespace Nora.Bff.Api.Domain.Contracts.v1.Services.Order;

public interface IOrderService
{
    Task CreateAsync(CreateOrderRequest request);
    Task<OrderResponse> GetByIdAsync(int id);
}