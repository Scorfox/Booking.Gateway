using Booking.Gateway.Application.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTables;

public sealed record GetTablesRequest : RequestWithPagination, IRequest<GetTablesResponse>
{
    [FromRoute]
    public Guid FilialId { get; set; }
}