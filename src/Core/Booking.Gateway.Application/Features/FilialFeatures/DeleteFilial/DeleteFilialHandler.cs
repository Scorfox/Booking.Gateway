using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.DeleteFilial;

public sealed class DeleteFilialHandler : IRequestHandler<DeleteFilialRequest, DeleteFilialResponse>
{
    private readonly IMapper _mapper;

    public DeleteFilialHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DeleteFilialResponse> Handle(DeleteFilialRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new DeleteFilialResponse();
    }
}