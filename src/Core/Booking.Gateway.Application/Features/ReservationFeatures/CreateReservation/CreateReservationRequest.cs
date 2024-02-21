using Booking.Gateway.Application.Models.Reservation;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;

public sealed record CreateReservationRequest : BaseReservationDto, IRequest<CreateReservationResponse> { }