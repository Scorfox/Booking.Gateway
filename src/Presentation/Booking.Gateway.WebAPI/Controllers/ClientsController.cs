﻿using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClients;
using Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;
using Booking.WebAPI.Attributes;
using Booking.WebAPI.Swagger.Requests.Client;
using Booking.WebAPI.Swagger.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Otus.Booking.Common;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ClientsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    [Roles(Roles.Client)]
    [ClientAuthorizationFilter]
    public async Task<GetClientResponse> GetClient([FromRoute] GetClientRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    [Roles(Roles.SuperAdmin)]
    public async Task<GetClientsResponse> GetClients([FromQuery] GetClientsRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [SwaggerRequestExample(typeof(CreateClientRequest), typeof(CreateClientRequestExamples))]
    [SwaggerResponseExample(200, typeof(ClientGettingExamples))]
    public async Task<CreateClientResponse> CreateClient([FromBody] CreateClientRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{Id}")]
    [Roles(Roles.SuperAdmin, Roles.Client)]
    [ClientAuthorizationFilter]
    [SwaggerRequestExample(typeof(UpdateClientRequest), typeof(UpdateClientRequestExamples))]
    [SwaggerResponseExample(200, typeof(ClientGettingExamples))]
    public async Task<UpdateClientResponse> UpdateClient(Guid id, [FromBody] UpdateClientRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{Id}")]
    [Roles(Roles.SuperAdmin, Roles.Client)]
    [ClientAuthorizationFilter]
    public async Task<DeleteClientResponse> DeleteClient([FromQuery] DeleteClientRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}