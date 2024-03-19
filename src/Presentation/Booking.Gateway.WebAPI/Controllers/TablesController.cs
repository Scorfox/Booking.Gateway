using Booking.Gateway.Application.Features.TableFeatures.CreateTable;
using Booking.Gateway.Application.Features.TableFeatures.DeleteTable;
using Booking.Gateway.Application.Features.TableFeatures.GetTable;
using Booking.Gateway.Application.Features.TableFeatures.GetTables;
using Booking.Gateway.Application.Features.TableFeatures.UpdateTable;
using Booking.WebAPI.Attributes;
using Booking.WebAPI.Swagger.Requests.Table;
using Booking.WebAPI.Swagger.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using MediatR;
using Otus.Booking.Common;

namespace Booking.WebAPI.Controllers;

[ApiController]
[Route("api/companies/{CompanyId}/filials/{FilialId}/tables")]
public class TablesController : ControllerBase
{
    private readonly IMediator _mediator;

    public TablesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    public async Task<GetTableResponse> GetTable([FromRoute] GetTableRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpGet]
    public async Task<GetTablesResponse> GetTables([FromQuery] GetTablesRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPost]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [CompanyAuthorizationFilter]
    [SwaggerRequestExample(typeof(CreateTableRequest), typeof(CreateTableRequestExamples))]
    [SwaggerResponseExample(200, typeof(TableGettingExamples))]
    public async Task<CreateTableResponse> CreateTable([FromBody] CreateTableRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpPut("{Id}")]
    [CompanyAuthorizationFilter]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [SwaggerRequestExample(typeof(UpdateTableRequest), typeof(UpdateTableRequestExamples))]
    [SwaggerResponseExample(200, typeof(TableGettingExamples))]
    public async Task<UpdateTableResponse> UpdateTable(Guid id, [FromBody] UpdateTableRequest request, CancellationToken cancellationToken)
    {
        request.Id = id;
        return await _mediator.Send(request, cancellationToken);
    }
    
    [HttpDelete("{Id}")]
    [Roles(Roles.SuperAdmin, Roles.Admin)]
    [CompanyAuthorizationFilter]
    public async Task<DeleteTableResponse> DeleteTable([FromQuery] DeleteTableRequest request, CancellationToken cancellationToken)
    {
        return await _mediator.Send(request, cancellationToken);
    }
}