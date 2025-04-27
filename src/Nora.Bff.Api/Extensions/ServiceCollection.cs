using Nora.Bff.Api.Domain.Contracts.v1.Services.Order;
using Nora.Bff.Api.Infrastructure.v1.Services.Order;

namespace Nora.Bff.Api.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddOrderService();

        return services;
    }

    public static IServiceCollection AddOrderService(this IServiceCollection services)
    {
        services
            .AddScoped<IOrderService, OrderService>();

        return services;
    }
}