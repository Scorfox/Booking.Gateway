using Booking.Gateway.Application.Models.Admin;
using MediatR;

namespace Booking.Gateway.Application.Features.AdminFeatures.UpdateAdmin;

public sealed record UpdateAdminRequest : BaseAdminDto, IRequest<UpdateAdminResponse>
{
    public Guid Id { get; set; }
}