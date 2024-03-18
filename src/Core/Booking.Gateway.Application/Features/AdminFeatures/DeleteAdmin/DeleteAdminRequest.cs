using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.AdminFeatures.DeleteAdmin;

public sealed record DeleteAdminRequest : RequestById, IRequest<DeleteAdminResponse> { }