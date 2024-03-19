using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Table;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTables;

public record GetTablesResponse : ResponseWithPagination<TableGettingDto>;