using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.DeleteFilial;

public sealed record DeleteFilialRequest : RequestById, IRequest<DeleteFilialResponse>;