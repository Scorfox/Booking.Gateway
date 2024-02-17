using AutoMapper;
using Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;
using Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;
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
    }
}