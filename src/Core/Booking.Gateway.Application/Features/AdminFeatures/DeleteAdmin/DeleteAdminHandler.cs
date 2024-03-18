using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.AdminFeatures.DeleteAdmin;

public sealed class DeleteAdminHandler : IRequestHandler<DeleteAdminRequest, DeleteAdminResponse>
{
    private readonly IRequestClient<ContractRequests.DeleteUser> _requestClient;
    private readonly IMapper _mapper;

    public DeleteAdminHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<DeleteAdminResponse> Handle(DeleteAdminRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<DeleteUserResult>(_mapper.Map<ContractRequests.DeleteUser>(request), cancellationToken);
        return _mapper.Map<DeleteAdminResponse>(response.Message);
    }
}