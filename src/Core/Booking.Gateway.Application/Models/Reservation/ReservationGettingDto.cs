namespace Booking.Gateway.Application.Models.Reservation;

public record ReservationGettingDto : BaseReservationDto
{
    public Guid Id { get; set; }
}