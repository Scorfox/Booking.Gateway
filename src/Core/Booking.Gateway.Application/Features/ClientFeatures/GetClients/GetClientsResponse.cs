using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Client;

namespace Booking.Gateway.Application.Features.ClientFeatures.GetClients;

public record GetClientsResponse : ResponseWithPagination<ClientGettingDto>
{
    
}