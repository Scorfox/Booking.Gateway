namespace Booking.Gateway.Application.Models.User;

public abstract record BaseUserDto
{
    public string Email { get; set; }
    public string Login { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string PhoneNumber { get; set; }
}