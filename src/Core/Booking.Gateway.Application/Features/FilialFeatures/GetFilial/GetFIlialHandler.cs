using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilial;

public sealed class GetFilialHandler : IRequestHandler<GetFilialRequest, GetFilialResponse>
{
    private readonly IMapper _mapper;

    public GetFilialHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetFilialResponse> Handle(GetFilialRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetFilialResponse();
    }
}