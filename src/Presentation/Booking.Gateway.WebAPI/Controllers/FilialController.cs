using Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;
using Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;
using Booking.Gateway.Application.Features.FilialFeatures.DeleteFilial;
using Booking.Gateway.Application.Features.FilialFeatures.GetFilial;
using Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;
using Booking.WebAPI.Swagger.Requests.Filial;
using Booking.WebAPI.Swagger.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using MediatR;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/filial")]
public class FilialController : ControllerBase
{
    private readonly IMediator _mediator;

    public FilialController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    public async Task<GetFilialResponse> GetFilial([FromRoute] GetFilialRequest request, 
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetCompaniesResponse> GetCompanies([FromQuery] GetCompaniesRequest request, 
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [SwaggerRequestExample(typeof(CreateFilialRequest), typeof(CreateFilialRequestExamples))]
    [SwaggerResponseExample(200, typeof(FilialGettingExamples))]
    public async Task<CreateFilialResponse> CreateFilial([FromBody] CreateFilialRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{Id}")]
    [SwaggerRequestExample(typeof(UpdateFilialRequest), typeof(UpdateFilialRequestExamples))]
    [SwaggerResponseExample(200, typeof(FilialGettingExamples))]
    public async Task<UpdateFilialResponse> UpdateFilial(Guid id, [FromBody] UpdateFilialRequest request,
        CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{Id}")]
    public async Task<DeleteFilialResponse> DeleteFilial([FromQuery] DeleteFilialRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}