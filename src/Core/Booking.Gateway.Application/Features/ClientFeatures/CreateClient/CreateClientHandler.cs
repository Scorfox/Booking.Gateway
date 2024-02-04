using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.CreateClient;

public sealed class CreateClientHandler : IRequestHandler<CreateClientRequest, CreateClientResponse>
{
    private readonly IMapper _mapper;

    public CreateClientHandler(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new CreateClientResponse();
    }
}