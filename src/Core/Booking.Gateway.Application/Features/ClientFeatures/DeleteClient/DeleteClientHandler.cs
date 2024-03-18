using AutoMapper;
using Booking.Gateway.Application.Features.AdminFeatures.DeleteAdmin;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.User.Requests;

namespace Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;

public sealed class DeleteClientHandler : IRequestHandler<DeleteClientRequest, DeleteClientResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.DeleteUser> _requestClient;

    public DeleteClientHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteUser> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<DeleteClientResponse> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<DeleteUserResult>(_mapper.Map<ContractRequests.DeleteUser>(request), cancellationToken);
        return _mapper.Map<DeleteClientResponse>(response.Message);
    }
}