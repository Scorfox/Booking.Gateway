using AutoMapper;
using Booking.Gateway.Application.Features.AuthFeatures;
using Otus.Booking.Common.Booking.Contracts.Auth.Requests;
using Otus.Booking.Common.Booking.Contracts.Auth.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class AuthMapper : Profile
{
    public AuthMapper()
    {
        CreateMap<AuthenticateRequest, Authenticate>();
        CreateMap<AuthenticateResult, AuthenticateResponse>();
    }
}