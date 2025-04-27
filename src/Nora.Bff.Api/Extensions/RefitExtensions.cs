using Nora.Bff.Api.Domain.Clients.v1.Order.Order;
using Nora.Core.Api.Refit.Extensions;

namespace Nora.Bff.Api.Extensions;

public static class RefitExtensions
{
    public static IServiceCollection AddRefitClients(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddOrderClients(configuration);

        return services;
    }

    public static IServiceCollection AddOrderClients(this IServiceCollection services, IConfiguration configuration)
    {
        var order = configuration.GetSection("ServiceEndpoints").GetValue<string>("Order");

        services
            .AddRefitClient<IOrderClient>(order + "/v1/orders");

        return services;
    }
}