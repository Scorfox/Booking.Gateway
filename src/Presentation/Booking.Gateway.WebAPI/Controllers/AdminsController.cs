using Booking.Gateway.Application.Features.AdminFeatures.CreateAdmin;
using Booking.Gateway.Application.Features.AdminFeatures.DeleteAdmin;
using Booking.Gateway.Application.Features.AdminFeatures.GetAdmin;
using Booking.Gateway.Application.Features.AdminFeatures.GetAdmins;
using Booking.Gateway.Application.Features.AdminFeatures.UpdateAdmin;
using Booking.WebAPI.Attributes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Otus.Booking.Common;

namespace Booking.WebAPI.Controllers;

[Route("api/companies/{CompanyId}/admins")]
[Roles(Roles.SuperAdmin, Roles.Admin)]
[CompanyAuthorizationFilter]
public class AdminsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AdminsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    public async Task<GetAdminResponse> GetAdmin([FromRoute] GetAdminRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetAdminsResponse> GetAdmins([FromQuery] GetAdminsRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    public async Task<CreateAdminResponse> CreateAdmin([FromBody] CreateAdminRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{Id}")]
    public async Task<UpdateAdminResponse> UpdateAdmin(Guid id, [FromBody] UpdateAdminRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{Id}")]
    public async Task<DeleteAdminResponse> DeleteAdmin(DeleteAdminRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}