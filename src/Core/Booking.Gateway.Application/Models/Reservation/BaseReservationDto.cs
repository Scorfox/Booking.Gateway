namespace Booking.Gateway.Application.Models.Reservation;

public abstract record BaseReservationDto
{
    public Guid TableId { get; set; }
    
    public Guid WhoBookedId { get; set; }
    
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
}