namespace Nora.Bff.Api.Domain.Clients.v1.User.User;

public sealed class CreateUserRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public CreateUserAddressRequest Address { get; set; }
}