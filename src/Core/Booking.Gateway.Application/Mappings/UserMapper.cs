using AutoMapper;
using Booking.Gateway.Application.Features.AdminFeatures.CreateAdmin;
using Booking.Gateway.Application.Features.AdminFeatures.UpdateAdmin;
using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;
using Otus.Booking.Common;
using Otus.Booking.Common.Booking.Contracts.User.Models;
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
        
        CreateMap<CreateAdminRequest, CreateUser>()
            .ForMember(d => d.RoleId, e => e.MapFrom(s => Roles.GetAllRolesWithIds()[Roles.Admin]));
        CreateMap<CreateUserResult, CreateAdminResponse>();
        
        CreateMap<UpdateAdminRequest, UpdateUser>()
            .ForMember(d => d.RoleId, e => e.MapFrom(s => Roles.GetAllRolesWithIds()[Roles.Admin]));
        CreateMap<UpdateUserResult, UpdateAdminResponse>();

        CreateMap<GetClientRequest, GetUserById>();
        CreateMap<GetUserResult, GetClientResponse>();
    }
}