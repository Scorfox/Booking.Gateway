using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Filial;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilials;

public record GetFilialsResponse : ResponseWithPagination<FilialGettingDto>;