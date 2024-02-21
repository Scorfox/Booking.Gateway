using Booking.Gateway.Application.Models.Table;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.UpdateTable;

public sealed record UpdateTableRequest : BaseTableDto, IRequest<UpdateTableResponse>
{
    public Guid Id { get; set; }
}