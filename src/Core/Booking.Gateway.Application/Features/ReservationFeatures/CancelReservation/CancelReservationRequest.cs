using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Models.Reservation;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.CancelReservation;

public sealed record CancelReservationRequest : BaseReservationDto, IRequest<CreateReservationResponse>;