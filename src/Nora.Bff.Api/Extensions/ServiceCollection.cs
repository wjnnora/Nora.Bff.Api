using Nora.Bff.Api.Domain.Contracts.v1.Services.Order;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;
using Nora.Bff.Api.Infrastructure.v1.Services.Order;
using Nora.Bff.Api.Infrastructure.v1.Services.Product;

namespace Nora.Bff.Api.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddOrderService()
            .AddProductService();

        return services;
    }

    public static IServiceCollection AddOrderService(this IServiceCollection services)
    {
        services
            .AddScoped<IOrderService, OrderService>();

        return services;
    }

    public static IServiceCollection AddProductService(this IServiceCollection services)
    {
        services
            .AddScoped<IProductService, ProductService>()
            .AddScoped<ICategoryService, CategoryService>();

        return services;
    }
}