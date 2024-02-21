﻿using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Reservation.Requests;

namespace Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;

public sealed class CreateReservationHandler : IRequestHandler<CreateReservationRequest, CreateReservationResponse>
{
    private readonly IRequestClient<ContractRequests.CreateReservation> _requestReservation;
    private readonly IMapper _mapper;

    public CreateReservationHandler(IMapper mapper, IRequestClient<ContractRequests.CreateReservation> requestReservation)
    {
        _mapper = mapper;
        _requestReservation = requestReservation;
    }
    
    public async Task<CreateReservationResponse> Handle(CreateReservationRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestReservation.GetResponse<CreateReservationResult>(_mapper.Map<ContractRequests.CreateReservation>(request), cancellationToken);
        return _mapper.Map<CreateReservationResponse>(response.Message);
    }
}