using Booking.Gateway.Application.Models.Reservation;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;

public sealed record GetReservationResponse : ReservationGettingDto
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}