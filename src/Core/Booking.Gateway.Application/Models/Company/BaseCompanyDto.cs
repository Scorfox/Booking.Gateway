namespace Booking.Gateway.Application.Models.Company;

public abstract record BaseCompanyDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Inn { get; set; }
    public string MainAddress { get; set; }
}