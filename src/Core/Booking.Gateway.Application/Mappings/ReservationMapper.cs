using AutoMapper;
using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;
using Otus.Booking.Common.Booking.Contracts.Reservation.Requests;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class ReservationMapper : Profile
{
    public ReservationMapper()
    {
        CreateMap<CreateReservationRequest, CreateReservation>();
        CreateMap<CreateReservationResult, CreateReservationResponse>();

        CreateMap<UpdateReservationRequest, UpdateReservation>();
        CreateMap<UpdateReservationResult, UpdateReservationResponse>();
    }
}