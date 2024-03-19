using Booking.Gateway.Application.Models.Admin;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Features.AdminFeatures.CreateAdmin;

public sealed record CreateAdminRequest : BaseAdminDto, IRequest<CreateAdminResponse>
{
    [FromRoute]
    public Guid CompanyId { get; set; }
    public string Password { get; set; }
}