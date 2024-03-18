using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Models;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClient;

public sealed class GetClientHandler : IRequestHandler<GetClientRequest, GetClientResponse>
{
    private readonly IRequestClient<ContractRequests.GetUserById> _requestUser;
    private readonly IMapper _mapper;

    public GetClientHandler(IMapper mapper, IRequestClient<ContractRequests.GetUserById> requestUser)
    {
        _mapper = mapper;
        _requestUser = requestUser;
    }

    public async Task<GetClientResponse> Handle(GetClientRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Auth
        return new GetClientResponse();
    }
}