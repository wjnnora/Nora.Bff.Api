using Nora.Bff.Api.Domain.Clients.v1.User.User;
using Nora.Bff.Api.Domain.Contracts.v1.Services.User;

namespace Nora.Bff.Api.Infrastructure.v1.Services.User;

public sealed class UserService(IUserClient userClient) : IUserService
{
    public async Task CreateAsync(CreateUserRequest request)
        => await userClient.CreateAsync(request);

    public async Task<UserResponse> GetAsync(int id)
        => await userClient.GetAsync(id);
}