namespace Booking.Gateway.Application.Models.Company;

public record CompanyGettingDto : BaseCompanyDto
{
    public Guid Id { get; set; }
}