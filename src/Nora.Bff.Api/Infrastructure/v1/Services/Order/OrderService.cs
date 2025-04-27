using Nora.Bff.Api.Domain.Clients.v1.Order.Order;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Order;

namespace Nora.Bff.Api.Infrastructure.v1.Services.Order;

public sealed class OrderService(IOrderClient orderClient) : IOrderService
{
    public async Task CreateAsync(CreateOrderRequest request)
        => await orderClient.CreateAsync(request);

    public Task<OrderResponse> GetByIdAsync(int id)
        => orderClient.GetByIdAsync(id);
}