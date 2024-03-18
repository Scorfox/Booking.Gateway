using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.AdminFeatures.CreateAdmin;

public sealed class CreateAdminHandler : IRequestHandler<CreateAdminRequest, CreateAdminResponse>
{
    private readonly IRequestClient<ContractRequests.CreateUser> _requestClient;
    private readonly IMapper _mapper;

    public CreateAdminHandler(IMapper mapper, IRequestClient<ContractRequests.CreateUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }
    
    public async Task<CreateAdminResponse> Handle(CreateAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<CreateUserResult>(_mapper.Map<ContractRequests.CreateUser>(request), cancellationToken);
        return _mapper.Map<CreateAdminResponse>(response.Message);
    }
}