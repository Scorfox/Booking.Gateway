using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Admin;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmins;

public record GetAdminsResponse : ResponseWithPagination<AdminGettingDto>;