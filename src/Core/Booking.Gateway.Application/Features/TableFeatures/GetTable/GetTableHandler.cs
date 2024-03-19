using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTable;

public sealed class GetTableHandler : IRequestHandler<GetTableRequest, GetTableResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetTableById> _requestClient;

    public GetTableHandler(IMapper mapper, IRequestClient<ContractRequests.GetTableById> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetTableResponse> Handle(GetTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetTableResult>
            (_mapper.Map<ContractRequests.GetTableById>(request), cancellationToken);
        
        return _mapper.Map<GetTableResponse>(response.Message);
    }
}