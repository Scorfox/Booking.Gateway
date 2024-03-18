using AutoMapper;
using Booking.Gateway.Application.Features.TableFeatures.CreateTable;
using Booking.Gateway.Application.Features.TableFeatures.GetTable;
using Booking.Gateway.Application.Features.TableFeatures.GetTables;
using Booking.Gateway.Application.Features.TableFeatures.UpdateTable;
using Otus.Booking.Common.Booking.Contracts.Table.Models;
using Otus.Booking.Common.Booking.Contracts.Table.Requests;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using TableGettingDto = Booking.Gateway.Application.Models.Table.TableGettingDto;

namespace Booking.Gateway.Application.Mappings;

public sealed class TableMapper : Profile
{
    public TableMapper()
    {
        CreateMap<CreateTableRequest, CreateTable>();
        CreateMap<CreateTableResult, CreateTableResponse>();

        CreateMap<UpdateTableRequest, UpdateTable>();
        CreateMap<UpdateTableResult, UpdateTableResponse>();

        CreateMap<GetTableRequest, GetTableById>();
        CreateMap<GetTableResult, GetTableResponse>();
        
        CreateMap<GetTablesRequest, GetTablesList>();
        CreateMap<Otus.Booking.Common.Booking.Contracts.Table.Models.TableGettingDto, TableGettingDto>();
    }
}