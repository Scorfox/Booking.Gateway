using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.DeleteTable;

public sealed class DeleteTableHandler : IRequestHandler<DeleteTableRequest, DeleteTableResponse>
{
    private readonly IMapper _mapper;

    public DeleteTableHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DeleteTableResponse> Handle(DeleteTableRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new DeleteTableResponse();
    }
}