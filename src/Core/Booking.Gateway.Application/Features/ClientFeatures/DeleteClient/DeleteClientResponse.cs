namespace Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;

public sealed record DeleteClientResponse
{
    public Guid Id { get; set; }
}