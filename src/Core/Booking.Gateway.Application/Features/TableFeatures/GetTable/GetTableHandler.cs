using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTable;

public sealed class GetTableHandler : IRequestHandler<GetTableRequest, GetTableResponse>
{
    private readonly IMapper _mapper;

    public GetTableHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetTableResponse> Handle(GetTableRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetTableResponse();
    }
}