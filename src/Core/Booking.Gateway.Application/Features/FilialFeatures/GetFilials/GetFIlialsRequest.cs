using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilials;

public sealed record GetFilialsRequest : RequestWithPagination, IRequest<GetFilialsResponse> { }