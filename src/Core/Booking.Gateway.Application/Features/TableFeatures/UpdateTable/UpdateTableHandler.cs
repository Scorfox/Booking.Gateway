using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.UpdateTable;

public sealed class UpdateTableHandler : IRequestHandler<UpdateTableRequest, UpdateTableResponse>
{
    private readonly IRequestClient<ContractRequests.UpdateTable> _requestTable;
    private readonly IMapper _mapper;

    public UpdateTableHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateTable> requestTable)
    {
        _mapper = mapper;
        _requestTable = requestTable;

    }
    
    public async Task<UpdateTableResponse> Handle(UpdateTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestTable.GetResponse<UpdateTableResult>(_mapper.Map<ContractRequests.UpdateTable>(request), cancellationToken);
        return _mapper.Map<UpdateTableResponse>(response.Message);
    }
}