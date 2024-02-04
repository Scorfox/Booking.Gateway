using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClients;
using Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController : ControllerBase
{
    private readonly IMediator _mediator;

    public ClientController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetClientResponse>> GetClient([FromQuery] GetClientRequest request, 
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpGet]
    public async Task<ActionResult<GetClientsResponse>> GetClients([FromQuery] GetClientsRequest request, 
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<CreateClientResponse>> CreateClient([FromBody] CreateClientRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateClientResponse>> UpdateClient([FromQuery] Guid id, [FromBody] UpdateClientRequest request,
        CancellationToken cancellationToken)
    {
        request.Id = id;
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<DeleteClientResponse>> DeleteClient([FromQuery] DeleteClientRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}