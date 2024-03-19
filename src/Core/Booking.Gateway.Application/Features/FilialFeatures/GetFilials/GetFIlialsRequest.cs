using Booking.Gateway.Application.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilials;

public sealed record GetFilialsRequest : RequestWithPagination, IRequest<GetFilialsResponse>
{
    [FromRoute]
    public Guid CompanyId { get; set; }
}