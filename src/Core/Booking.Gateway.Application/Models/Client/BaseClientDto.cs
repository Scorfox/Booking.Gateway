namespace Booking.Gateway.Application.Models.Client;

public abstract record BaseClientDto
{
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    
    public string PhoneNumber { get; set; }
}