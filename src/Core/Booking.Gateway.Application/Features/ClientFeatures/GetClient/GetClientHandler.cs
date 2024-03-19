using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClient;

public sealed class GetClientHandler : IRequestHandler<GetClientRequest, GetClientResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetUserById> _requestClient;

    public GetClientHandler(IMapper mapper, IRequestClient<ContractRequests.GetUserById> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetClientResponse> Handle(GetClientRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetUserResult>
            (_mapper.Map<ContractRequests.GetUserById>(request), cancellationToken);
        
        return _mapper.Map<GetClientResponse>(response.Message);
    }
}