using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmin;

public sealed class GetAdminHandler : IRequestHandler<GetAdminRequest, GetAdminResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetUserById> _requestClient;

    public GetAdminHandler(IMapper mapper, IRequestClient<ContractRequests.GetUserById> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetAdminResponse> Handle(GetAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetUserResult>
            (_mapper.Map<ContractRequests.GetUserById>(request), cancellationToken);
        
        return _mapper.Map<GetAdminResponse>(response.Message);
    }
}