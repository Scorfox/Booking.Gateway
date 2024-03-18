using Booking.Gateway.Application.Models.Table;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Features.TableFeatures.CreateTable;

public sealed record CreateTableRequest : BaseTableDto, IRequest<CreateTableResponse>
{
    [FromRoute]
    public Guid FilialId { get; set; }
}