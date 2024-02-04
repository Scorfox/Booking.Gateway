using Booking.Gateway.Application.Models.Client;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;

public sealed record UpdateClientRequest : BaseClientDto, IRequest<UpdateClientResponse>
{
    public Guid Id { get; set; }
}