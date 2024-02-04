using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ClientFeatures.DeleteClient;

public sealed class DeleteClientHandler : IRequestHandler<DeleteClientRequest, DeleteClientResponse>
{
    private readonly IMapper _mapper;

    public DeleteClientHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DeleteClientResponse> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new DeleteClientResponse();
    }
}