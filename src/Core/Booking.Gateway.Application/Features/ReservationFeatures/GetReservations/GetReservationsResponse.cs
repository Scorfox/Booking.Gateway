using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Reservation;

namespace Booking.Gateway.Application.Features.ReservationFeatures.GetReservations;

public record GetReservationsResponse : ResponseWithPagination<ReservationGettingDto> { }