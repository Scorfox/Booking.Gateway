using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;

public sealed class UpdateClientHandler : IRequestHandler<UpdateClientRequest, UpdateClientResponse>
{
    private readonly IRequestClient<ContractRequests.UpdateUser> _requestClient;
    private readonly IMapper _mapper;

    public UpdateClientHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;

    }
    
    public async Task<UpdateClientResponse> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<UpdateUserResult>(_mapper.Map<ContractRequests.UpdateUser>(request), cancellationToken);
        return _mapper.Map<UpdateClientResponse>(response.Message);
    }
}