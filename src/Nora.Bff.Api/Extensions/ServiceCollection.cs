using Nora.Bff.Api.Domain.Contracts.v1.Services.Order;
using Nora.Bff.Api.Domain.Contracts.v1.Services.Product;
using Nora.Bff.Api.Domain.Contracts.v1.Services.User;
using Nora.Bff.Api.Infrastructure.v1.Services.Order;
using Nora.Bff.Api.Infrastructure.v1.Services.Product;
using Nora.Bff.Api.Infrastructure.v1.Services.User;

namespace Nora.Bff.Api.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddOrderService()
            .AddProductService()
            .AddUserService();

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

    public static IServiceCollection AddUserService(this IServiceCollection services)
    {
        services
            .AddScoped<IUserService, UserService>();

        return services;
    }
}