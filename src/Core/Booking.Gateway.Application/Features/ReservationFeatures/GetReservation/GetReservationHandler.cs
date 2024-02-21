using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;

public sealed class GetReservationHandler : IRequestHandler<GetReservationRequest, GetReservationResponse>
{
    private readonly IMapper _mapper;

    public GetReservationHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetReservationResponse> Handle(GetReservationRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetReservationResponse();
    }
}