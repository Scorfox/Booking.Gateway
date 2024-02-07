using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClient;

public sealed class GetClientHandler : IRequestHandler<GetClientRequest, GetClientResponse>
{
    private readonly IMapper _mapper;

    public GetClientHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetClientResponse> Handle(GetClientRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetClientResponse();
    }
}