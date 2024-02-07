using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Otus.Booking.Common.Booking.Contracts.Authentication.Requests;
using Otus.Booking.Common.Booking.Contracts.Authentication.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class CreateClientMapper : Profile
{
    public CreateClientMapper()
    {
        CreateMap<CreateClientRequest, CreateUser>();
        CreateMap<CreateUserResult, CreateClientResponse>();
    }
}