using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClient;

public sealed record GetClientRequest : RequestById, IRequest<GetClientResponse>;