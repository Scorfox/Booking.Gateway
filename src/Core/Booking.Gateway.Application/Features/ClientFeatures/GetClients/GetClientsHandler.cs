using AutoMapper;
using Booking.Gateway.Application.Models.Client;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Requests;
using Otus.Booking.Common.Booking.Contracts.User.Responses;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClients;

public sealed class GetClientsHandler : IRequestHandler<GetClientsRequest, GetClientsResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<GetClientsRequest> _requestClient;

    public GetClientsHandler(IMapper mapper, IRequestClient<GetClientsRequest> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetClientsResponse> Handle(GetClientsRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetUsersListResult>
            (_mapper.Map<GetUsersList>(request), cancellationToken);

        return new GetClientsResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<ClientGettingDto>>(response.Message.Elements)
        };
    }
}