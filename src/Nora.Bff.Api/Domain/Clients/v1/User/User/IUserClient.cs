using Refit;

namespace Nora.Bff.Api.Domain.Clients.v1.User.User;

public interface IUserClient
{
    [Post("")]
    Task CreateAsync([Body] CreateUserRequest request);

    [Get("/{id}")]
    Task<UserResponse> GetAsync(int id);
}