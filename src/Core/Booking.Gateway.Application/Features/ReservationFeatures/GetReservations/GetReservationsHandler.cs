using AutoMapper;
using Booking.Gateway.Application.Models.Reservation;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Reservation.Requests;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;

public sealed class GetReservationsHandler : IRequestHandler<GetReservationsRequest, GetReservationsResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<GetReservationsList> _requestClient;
    
    public GetReservationsHandler(IMapper mapper, IRequestClient<GetReservationsList> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetReservationsResponse> Handle(GetReservationsRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetReservationsListResult>
            (_mapper.Map<GetReservationsList>(request), cancellationToken);

        return new GetReservationsResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<ReservationGettingDto>>(response.Message.Elements)
        };
    }
}