using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.UpdateTable;

public sealed class UpdateTableHandler : IRequestHandler<UpdateTableRequest, UpdateTableResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.UpdateTable> _requestClient;

    public UpdateTableHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateTable> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }
    
    public async Task<UpdateTableResponse> Handle(UpdateTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<UpdateTableResult>
            (_mapper.Map<ContractRequests.UpdateTable>(request), cancellationToken);
        
        return _mapper.Map<UpdateTableResponse>(response.Message);
    }
}