using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.DeleteReservation;

public sealed record DeleteReservationRequest : RequestById, IRequest<DeleteReservationResponse> { }