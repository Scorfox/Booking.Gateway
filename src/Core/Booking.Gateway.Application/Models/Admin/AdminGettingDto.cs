namespace Booking.Gateway.Application.Models.Admin;

public record AdminGettingDto : BaseAdminDto
{
    public Guid Id { get; set; }
}