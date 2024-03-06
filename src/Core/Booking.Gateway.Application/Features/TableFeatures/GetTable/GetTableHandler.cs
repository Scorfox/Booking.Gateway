using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Requests;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTable;

public sealed class GetTableHandler : IRequestHandler<GetTableRequest, GetTableResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetTableId> _requestTable;

    public GetTableHandler(IMapper mapper, IRequestClient<ContractRequests.GetTableId> requestTable)
    {
        _mapper = mapper;
        _requestTable = requestTable;
    }

    public async Task<GetTableResponse> Handle(GetTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestTable.GetResponse<GetTableRequest>(_mapper.Map<GetTableId>(request));
        return _mapper.Map<GetTableResponse>(response.Message);
    }
}