using AutoMapper;
using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservation;
using Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;
using Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;
using Otus.Booking.Common.Booking.Contracts.Reservation.Models;
using Otus.Booking.Common.Booking.Contracts.Reservation.Requests;
using Otus.Booking.Common.Booking.Contracts.Reservation.Responses;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using ReservationGettingDto = Booking.Gateway.Application.Models.Reservation.ReservationGettingDto;

namespace Booking.Gateway.Application.Mappings;

public sealed class ReservationMapper : Profile
{
    public ReservationMapper()
    {
        CreateMap<CreateReservationRequest, CreateReservation>();
        CreateMap<CreateReservationResult, CreateReservationResponse>();

        CreateMap<UpdateReservationRequest, UpdateReservation>();
        CreateMap<UpdateReservationResult, UpdateReservationResponse>();

        CreateMap<GetReservationRequest, GetReservationById>();
        CreateMap<GetReservationResult, GetReservationResponse>();
        CreateMap<GetUserResult, GetReservationResponse>();
        
        CreateMap<GetReservationsRequest, GetReservationsList>();
        CreateMap<Otus.Booking.Common.Booking.Contracts.Reservation.Models.ReservationGettingDto, ReservationGettingDto>();
    }
}