namespace Booking.Gateway.Application.Common;

public abstract record RequestById
{
    public Guid Id { get; set; }
}