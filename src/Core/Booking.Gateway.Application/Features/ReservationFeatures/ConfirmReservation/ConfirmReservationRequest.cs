using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Models.Reservation;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.ConfirmReservation;

public sealed record ConfirmReservationRequest : BaseReservationDto, IRequest<CreateReservationResponse>;