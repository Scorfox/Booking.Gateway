using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

namespace Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;

public sealed class UpdateReservationHandler : IRequestHandler<UpdateReservationRequest, UpdateReservationResponse>
{
    private readonly IRequestClient<ContractRequests.UpdateReservation> _requestReservation;
    private readonly IMapper _mapper;

    public UpdateReservationHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateReservation> requestReservation)
    {
        _mapper = mapper;
        _requestReservation = requestReservation;

    }
    
    public async Task<UpdateReservationResponse> Handle(UpdateReservationRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestReservation.GetResponse<UpdateReservationResult>(_mapper.Map<ContractRequests.UpdateReservation>(request), cancellationToken);
        return _mapper.Map<UpdateReservationResponse>(response.Message);
    }
}