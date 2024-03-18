using Booking.Gateway.Application.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;

public sealed record GetReservationsRequest : RequestWithPagination, IRequest<GetReservationsResponse>
{
    [FromRoute]
    public Guid FilialId { get; set; }
}