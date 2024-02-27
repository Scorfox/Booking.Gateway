using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;
using Otus.Booking.Common;
using Otus.Booking.Common.Booking.Contracts.User.Requests;
using Otus.Booking.Common.Booking.Contracts.User.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<CreateClientRequest, CreateUser>()
            .ForMember(d => d.RoleId, e => e.MapFrom(s => Roles.GetAllRolesWithIds()[Roles.Client]));
        CreateMap<CreateUserResult, CreateClientResponse>();
        
        CreateMap<UpdateClientRequest, UpdateUser>()
            .ForMember(d => d.RoleId, e => e.MapFrom(s => Roles.GetAllRolesWithIds()[Roles.Client]));
        CreateMap<UpdateUserResult, UpdateClientResponse>();

        CreateMap<GetClientRequest, GetUserId>();
        CreateMap<GetUsersListResult, GetClientResponse>();
    }
}