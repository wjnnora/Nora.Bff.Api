using Nora.Bff.Api.Domain.Clients.v1.User.User;

namespace Nora.Bff.Api.Domain.Contracts.v1.Services.User;

public interface IUserService
{
    Task CreateAsync(CreateUserRequest request);
    Task<UserResponse> GetAsync(int id);
}