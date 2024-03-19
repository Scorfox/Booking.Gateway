using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.DeleteTable;

public sealed class DeleteTableHandler : IRequestHandler<DeleteTableRequest, DeleteTableResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.DeleteTable> _requestClient;

    public DeleteTableHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteTable> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<DeleteTableResponse> Handle(DeleteTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<DeleteTableResult>
            (_mapper.Map<ContractRequests.DeleteTable>(request), cancellationToken);
        
        return _mapper.Map<DeleteTableResponse>(response.Message);
    }
}