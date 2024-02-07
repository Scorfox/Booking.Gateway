using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClients;

public sealed class GetClientsHandler : IRequestHandler<GetClientsRequest, GetClientsResponse>
{
    private readonly IMapper _mapper;

    public GetClientsHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetClientsResponse> Handle(GetClientsRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetClientsResponse();
    }
}