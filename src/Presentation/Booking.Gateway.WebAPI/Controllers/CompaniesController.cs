using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Booking.WebAPI.Attributes;
using Booking.WebAPI.Swagger.Requests.Company;
using Booking.WebAPI.Swagger.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Otus.Booking.Common;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/companies")]
public class CompaniesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompaniesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{CompanyId}")]
    public async Task<GetCompanyResponse> GetCompany([FromQuery] GetCompanyRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetCompaniesResponse> GetCompanies([FromQuery] GetCompaniesRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [Roles(Roles.SuperAdmin)]
    [SwaggerRequestExample(typeof(CreateCompanyRequest), typeof(CreateCompanyRequestExamples))]
    [SwaggerResponseExample(200, typeof(CompanyGettingExamples))]
    public async Task<CreateCompanyResponse> CreateCompany([FromBody] CreateCompanyRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{CompanyId}")]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [CompanyAuthorizationFilter]
    [SwaggerRequestExample(typeof(UpdateCompanyRequest), typeof(UpdateCompanyRequestExamples))]
    [SwaggerResponseExample(200, typeof(CompanyGettingExamples))]
    public async Task<UpdateCompanyResponse> UpdateCompany(Guid id, [FromBody] UpdateCompanyRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{CompanyId}")]
    [Roles(Roles.SuperAdmin)]
    public async Task<DeleteCompanyResponse> DeleteCompany(DeleteCompanyRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}