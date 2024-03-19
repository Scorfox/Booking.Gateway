using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmins;

public sealed record GetAdminsRequest : RequestWithPagination, IRequest<GetAdminsResponse>;