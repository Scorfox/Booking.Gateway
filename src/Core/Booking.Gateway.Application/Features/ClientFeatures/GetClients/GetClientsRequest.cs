using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClients;

public sealed record GetClientsRequest : RequestWithPagination, IRequest<GetClientsResponse> { }