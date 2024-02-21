using Booking.Gateway.Application.Models.Reservation;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;

public sealed record UpdateReservationRequest : BaseReservationDto, IRequest<UpdateReservationResponse>
{
    public Guid Id { get; set; }
}