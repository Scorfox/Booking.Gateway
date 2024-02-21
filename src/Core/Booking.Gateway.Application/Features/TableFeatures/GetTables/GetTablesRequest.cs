using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTables;

public sealed record GetTablesRequest : RequestWithPagination, IRequest<GetTablesResponse> { }