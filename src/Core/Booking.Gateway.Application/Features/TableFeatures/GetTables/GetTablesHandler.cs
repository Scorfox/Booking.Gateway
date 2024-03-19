using AutoMapper;
using Booking.Gateway.Application.Models.Table;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Requests;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTables;

public sealed class GetTablesHandler : IRequestHandler<GetTablesRequest, GetTablesResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<GetTablesList> _requestClient;

    public GetTablesHandler(IMapper mapper, IRequestClient<GetTablesList> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetTablesResponse> Handle(GetTablesRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetTablesListResult>
            (_mapper.Map<GetTablesList>(request), cancellationToken);

        return new GetTablesResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<TableGettingDto>>(response.Message.Elements)
        };
    }
}