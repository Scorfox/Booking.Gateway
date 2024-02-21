namespace Booking.Gateway.Application.Models.Reservation;

public abstract record BaseReservationDto
{
    public Guid TableId { get; set; }
    
    public Guid WhoBookedId { get; set; }
    public Guid? WhoConfirmedId { get; set; }
    public Guid? WhoCancelledId { get; set; }
    
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
}