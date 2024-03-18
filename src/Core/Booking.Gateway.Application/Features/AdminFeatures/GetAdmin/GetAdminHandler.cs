using AutoMapper;
using MassTransit;
using MediatR;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmin;

public sealed class GetAdminHandler : IRequestHandler<GetAdminRequest, GetAdminResponse>
{
    private readonly IRequestClient<ContractRequests.GetUserById> _requestUser;
    private readonly IMapper _mapper;

    public GetAdminHandler(IMapper mapper, IRequestClient<ContractRequests.GetUserById> requestUser)
    {
        _mapper = mapper;
        _requestUser = requestUser;
    }

    public async Task<GetAdminResponse> Handle(GetAdminRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Auth
        return new GetAdminResponse();
    }
}