using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Booking.WebAPI.Swagger.Requests.Company;
using Booking.WebAPI.Swagger.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/company")]
public class CompanyController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompanyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<GetCompanyResponse> GetCompany([FromQuery] GetCompanyRequest request, 
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
    [SwaggerRequestExample(typeof(CreateCompanyRequest), typeof(CreateCompanyRequestExamples))]
    [SwaggerResponseExample(200, typeof(CompanyGettingExamples))]
    public async Task<CreateCompanyResponse> CreateCompany([FromBody] CreateCompanyRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{id}")]
    [SwaggerRequestExample(typeof(UpdateCompanyRequest), typeof(UpdateCompanyRequestExamples))]
    [SwaggerResponseExample(200, typeof(CompanyGettingExamples))]
    public async Task<UpdateCompanyResponse> UpdateCompany(Guid id, [FromBody] UpdateCompanyRequest request,
        CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{id}")]
    public async Task<DeleteCompanyResponse> DeleteCompany([FromQuery] DeleteCompanyRequest request,
        CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}