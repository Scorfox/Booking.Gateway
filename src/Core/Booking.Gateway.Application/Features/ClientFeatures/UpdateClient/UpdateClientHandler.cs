using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;

public sealed class UpdateClientHandler : IRequestHandler<UpdateClientRequest, UpdateClientResponse>
{
    private readonly IMapper _mapper;

    public UpdateClientHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<UpdateClientResponse> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new UpdateClientResponse();
    }
}