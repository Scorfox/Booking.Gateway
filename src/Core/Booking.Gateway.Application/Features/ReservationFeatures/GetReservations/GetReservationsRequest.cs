using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;

public sealed record GetReservationsRequest : RequestWithPagination, IRequest<GetReservationsResponse> { }