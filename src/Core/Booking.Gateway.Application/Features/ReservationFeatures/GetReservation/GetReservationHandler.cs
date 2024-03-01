using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Reservation.Models;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;

public sealed class GetReservationHandler : IRequestHandler<GetReservationRequest, GetReservationResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetReservationId> _requestReservation;

    public GetReservationHandler(IMapper mapper, IRequestClient<ContractRequests.GetReservationId> requestReservation)
    {
        _mapper = mapper;
        _requestReservation = requestReservation;
    }

    public async Task<GetReservationResponse> Handle(GetReservationRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestReservation.GetResponse<FullReservationDto>(_mapper.Map<ContractRequests.GetReservationId>(request));
        return _mapper.Map<GetReservationResponse>(response.Message);
    }
}