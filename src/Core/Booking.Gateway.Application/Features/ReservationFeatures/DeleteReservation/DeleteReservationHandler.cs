using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.ReservationFeatures.DeleteReservation;

public sealed class DeleteReservationHandler : IRequestHandler<DeleteReservationRequest, DeleteReservationResponse>
{
    private readonly IMapper _mapper;

    public DeleteReservationHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DeleteReservationResponse> Handle(DeleteReservationRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new DeleteReservationResponse();
    }
}