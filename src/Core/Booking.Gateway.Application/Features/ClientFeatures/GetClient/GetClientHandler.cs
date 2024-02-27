using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClient;

public sealed class GetClientHandler : IRequestHandler<GetClientRequest, GetClientResponse>
{
    private readonly IRequestClient<ContractRequests.GetUserId> _requestUser;
    private readonly IMapper _mapper;

    public GetClientHandler(IMapper mapper, IRequestClient<ContractRequests.GetUserId> requestUser)
    {
        _mapper = mapper;
        _requestUser = requestUser;
    }

    public async Task<GetClientResponse> Handle(GetClientRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestUser.GetResponse<GetUsersListResult>(_mapper.Map<ContractRequests.GetUserId>(request));
        return _mapper.Map<GetClientResponse>(response.Message);
    }
}