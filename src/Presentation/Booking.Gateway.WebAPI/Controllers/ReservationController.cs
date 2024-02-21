using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.DeleteReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;
using Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;
using Booking.WebAPI.Swagger.Requests.Reservation;
using Booking.WebAPI.Swagger.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using MediatR;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/reservation")]
public class ReservationController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReservationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<GetReservationResponse> GetReservation([FromQuery] GetReservationRequest request, 
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetReservationsResponse> GetReservations([FromQuery] GetReservationsRequest request, 
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [SwaggerRequestExample(typeof(CreateReservationRequest), typeof(CreateReservationRequestExamples))]
    [SwaggerResponseExample(200, typeof(ReservationGettingExamples))]
    public async Task<CreateReservationResponse> CreateReservation([FromBody] CreateReservationRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{id}")]
    [SwaggerRequestExample(typeof(UpdateReservationRequest), typeof(UpdateReservationRequestExamples))]
    [SwaggerResponseExample(200, typeof(ReservationGettingExamples))]
    public async Task<UpdateReservationResponse> UpdateReservation(Guid id, [FromBody] UpdateReservationRequest request,
        CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{id}")]
    public async Task<DeleteReservationResponse> DeleteReservation([FromQuery] DeleteReservationRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}