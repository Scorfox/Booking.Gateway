using Booking.Gateway.Application.Models.Client;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.CreateClient;

public sealed record CreateClientRequest : BaseClientDto, IRequest<CreateClientResponse>
{
}