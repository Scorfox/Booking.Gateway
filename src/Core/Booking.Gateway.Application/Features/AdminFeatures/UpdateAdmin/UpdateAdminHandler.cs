using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.AdminFeatures.UpdateAdmin;

public sealed class UpdateAdminHandler : IRequestHandler<UpdateAdminRequest, UpdateAdminResponse>
{
    private readonly IRequestClient<ContractRequests.UpdateUser> _requestClient;
    private readonly IMapper _mapper;

    public UpdateAdminHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;

    }
    
    public async Task<UpdateAdminResponse> Handle(UpdateAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<UpdateUserResult>(_mapper.Map<ContractRequests.UpdateUser>(request), cancellationToken);
        return _mapper.Map<UpdateAdminResponse>(response.Message);
    }
}