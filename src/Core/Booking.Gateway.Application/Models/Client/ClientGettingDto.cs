namespace Booking.Gateway.Application.Models.Client;

public record ClientGettingDto : BaseClientDto
{
    public Guid Id { get; set; }
}