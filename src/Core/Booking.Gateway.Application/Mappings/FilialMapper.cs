using AutoMapper;
using Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;
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
        CreateMap<CreateFilialRequest, CreateFilial>();
        CreateMap<CreateFilialResult, CreateFilialResponse>();

        CreateMap<UpdateFilialRequest, UpdateFilial>();
        CreateMap<UpdateFilialResult, UpdateFilialResponse>();

        CreateMap<GetFilialRequest, GetFilialById>();
        CreateMap<GetFilialsRequest, GetFilialsList>();
        
        CreateMap<Otus.Booking.Common.Booking.Contracts.Filial.Models.FilialGettingDto, FilialGettingDto>();
    }
}