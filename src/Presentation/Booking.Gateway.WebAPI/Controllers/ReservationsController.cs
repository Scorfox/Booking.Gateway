using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;
using Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;
using Booking.WebAPI.Attributes;
using Booking.WebAPI.Swagger.Requests.Reservation;
using Booking.WebAPI.Swagger.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Otus.Booking.Common;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/companies/{CompanyId}/filials/{FilialId}/tables/{TableId}/reservations")]
public class ReservationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReservationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [CompanyAuthorizationFilter]
    public async Task<GetReservationResponse> GetReservation([FromRoute] GetReservationRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetReservationsResponse> GetReservations([FromQuery] GetReservationsRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [Authorize]
    [SwaggerRequestExample(typeof(CreateReservationRequest), typeof(CreateReservationRequestExamples))]
    [SwaggerResponseExample(200, typeof(ReservationGettingExamples))]
    public async Task<CreateReservationResponse> CreateReservation([FromBody] CreateReservationRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPatch("{Id}/cancel")]
    [Authorize]
    [SwaggerRequestExample(typeof(UpdateReservationRequest), typeof(UpdateReservationRequestExamples))]
    [SwaggerResponseExample(200, typeof(ReservationGettingExamples))]
    public async Task<UpdateReservationResponse> CancelReservation(Guid id, [FromBody] UpdateReservationRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPatch("{Id}/confirm")]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [CompanyAuthorizationFilter]
    [SwaggerRequestExample(typeof(UpdateReservationRequest), typeof(UpdateReservationRequestExamples))]
    [SwaggerResponseExample(200, typeof(ReservationGettingExamples))]
    public async Task<UpdateReservationResponse> ConfirmReservation(Guid id, [FromBody] UpdateReservationRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
}