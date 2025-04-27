using Nora.Bff.Api.Domain.Clients.v1.Order.Order;
using Nora.Bff.Api.Domain.Clients.v1.Product.Category;
using Nora.Bff.Api.Domain.Clients.v1.Product.Product;
using Nora.Core.Api.Refit.Extensions;

namespace Nora.Bff.Api.Extensions;

public static class RefitExtensions
{
    public static IServiceCollection AddRefitClients(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddOrderClients(configuration)
            .AddProductClients(configuration);

        return services;
    }

    public static IServiceCollection AddOrderClients(this IServiceCollection services, IConfiguration configuration)
    {
        var order = configuration.GetSection("ServiceEndpoints").GetValue<string>("Order");

        services
            .AddRefitClient<IOrderClient>(order + "/v1/orders");

        return services;
    }

    public static IServiceCollection AddProductClients(this IServiceCollection services, IConfiguration configuration)
    {
        var product = configuration.GetSection("ServiceEndpoints").GetValue<string>("Product");

        services
            .AddRefitClient<IProductClient>(product + "/v1/products")
            .AddRefitClient<ICategoryClient>(product + "/v1/categories");

        return services;
    }
}