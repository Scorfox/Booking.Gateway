using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilials;

public sealed class GetFilialsHandler : IRequestHandler<GetFilialsRequest, GetFilialsResponse>
{
    private readonly IMapper _mapper;

    public GetFilialsHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetFilialsResponse> Handle(GetFilialsRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetFilialsResponse();
    }
}