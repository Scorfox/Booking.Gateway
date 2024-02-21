using AutoMapper;
using Booking.Gateway.Application.Features.TableFeatures.CreateTable;
using Booking.Gateway.Application.Features.TableFeatures.UpdateTable;
using Otus.Booking.Common.Booking.Contracts.Table.Requests;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class TableMapper : Profile
{
    public TableMapper()
    {
        CreateMap<CreateTableRequest, CreateTable>();
        CreateMap<CreateTableResult, CreateTableResponse>();

        CreateMap<UpdateTableRequest, UpdateTable>();
        CreateMap<UpdateTableResult, UpdateTableResponse>();
    }
}