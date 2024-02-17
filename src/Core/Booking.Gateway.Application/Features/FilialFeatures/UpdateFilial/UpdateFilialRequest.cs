using Booking.Gateway.Application.Models.Filial;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;

public sealed record UpdateFilialRequest : BaseFilialDto, IRequest<UpdateFilialResponse>
{
    public Guid Id { get; set; }
}