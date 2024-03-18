using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Reservation.Models;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;
using Otus.Booking.Common.Booking.Contracts.User.Requests;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;

public sealed class GetReservationHandler : IRequestHandler<GetReservationRequest, GetReservationResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetReservationById> _requestForReservation;
    private readonly IRequestClient<GetUserById> _requestForUser;

    public GetReservationHandler(
        IMapper mapper, 
        IRequestClient<ContractRequests.GetReservationById> requestReservation,
        IRequestClient<GetUserById> requestForUser
        )
    {
        _mapper = mapper;
        _requestForReservation = requestReservation;
        _requestForUser = requestForUser;
    }

    public async Task<GetReservationResponse> Handle(GetReservationRequest request, CancellationToken cancellationToken)
    {
        var reservationResult = (await _requestForReservation.GetResponse<GetReservationResult>
            (_mapper.Map<ContractRequests.GetReservationById>(request), cancellationToken)).Message;
        var clientInfo = (await _requestForUser.GetResponse<GetUserResult>
            (new GetUserById {Id = reservationResult.WhoBookedId}, cancellationToken)).Message;

        var response = _mapper.Map<GetReservationResponse>(reservationResult);
        _mapper.Map(clientInfo, response);

        return response;
    }
}