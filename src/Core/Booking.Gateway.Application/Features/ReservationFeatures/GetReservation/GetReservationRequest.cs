using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;

public sealed record GetReservationRequest : RequestById, IRequest<GetReservationResponse> { }