namespace Booking.Gateway.Application.Models.Common;

public abstract record BaseDeletionResponse
{
    public Guid Id { get; set; }
}