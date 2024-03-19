using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilial;

public sealed record GetFilialRequest : RequestById, IRequest<GetFilialResponse>;