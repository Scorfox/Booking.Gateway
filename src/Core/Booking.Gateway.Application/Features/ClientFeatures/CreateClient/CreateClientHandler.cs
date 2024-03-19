using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.CreateClient;

public sealed class CreateClientHandler : IRequestHandler<CreateClientRequest, CreateClientResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.CreateUser> _requestClient;

    public CreateClientHandler(IMapper mapper, IRequestClient<ContractRequests.CreateUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }
    
    public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<CreateUserResult>
            (_mapper.Map<ContractRequests.CreateUser>(request), cancellationToken);
        
        return _mapper.Map<CreateClientResponse>(response.Message);
    }
}