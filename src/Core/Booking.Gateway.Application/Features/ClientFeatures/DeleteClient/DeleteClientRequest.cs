using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;

public sealed record DeleteClientRequest : RequestById, IRequest<DeleteClientResponse>;