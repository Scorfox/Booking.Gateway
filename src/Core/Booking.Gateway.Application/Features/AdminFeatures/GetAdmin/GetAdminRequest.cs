using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmin;

public sealed record GetAdminRequest : RequestById, IRequest<GetAdminResponse>;