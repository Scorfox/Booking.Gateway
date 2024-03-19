using AutoMapper;
using Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;
using Booking.Gateway.Application.Features.FilialFeatures.DeleteFilial;
using Booking.Gateway.Application.Features.FilialFeatures.GetFilial;
using Booking.Gateway.Application.Features.FilialFeatures.GetFilials;
using Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;
using Booking.Gateway.Application.Models.Filial;
using Otus.Booking.Common.Booking.Contracts.Filial.Requests;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class FilialMapper : Profile
{
    public FilialMapper()
    {
        // Create
        CreateMap<CreateFilialRequest, CreateFilial>();
        CreateMap<CreateFilialResult, CreateFilialResponse>();
        
        // Read
        CreateMap<GetFilialRequest, GetFilialById>();
        CreateMap<GetFilialResult, GetFilialResponse>();
        
        CreateMap<GetFilialsRequest, GetFilialsList>();
        CreateMap<Otus.Booking.Common.Booking.Contracts.Filial.Models.FilialGettingDto, FilialGettingDto>();

        // Update
        CreateMap<UpdateFilialRequest, UpdateFilial>();
        CreateMap<UpdateFilialResult, UpdateFilialResponse>();
        
        // Delete
        CreateMap<DeleteFilialRequest, DeleteFilial>();
        CreateMap<DeleteFilialResult, DeleteFilialResponse>();
    }
}