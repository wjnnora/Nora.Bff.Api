namespace Nora.Bff.Api.Domain.Clients.v1.User.User;

public sealed class UserResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }
    public int AddressId { get; set; }
    public UserAddressResponse Address { get; set; }
}