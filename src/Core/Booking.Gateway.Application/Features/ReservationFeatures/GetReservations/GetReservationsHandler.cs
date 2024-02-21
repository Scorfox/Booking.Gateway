using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;

public sealed class GetReservationsHandler : IRequestHandler<GetReservationsRequest, GetReservationsResponse>
{
    private readonly IMapper _mapper;

    public GetReservationsHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetReservationsResponse> Handle(GetReservationsRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetReservationsResponse();
    }
}