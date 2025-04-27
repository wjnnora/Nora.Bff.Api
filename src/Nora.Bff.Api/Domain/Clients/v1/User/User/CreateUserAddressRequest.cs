namespace Nora.Bff.Api.Domain.Clients.v1.User.User;

public sealed class CreateUserAddressRequest
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}