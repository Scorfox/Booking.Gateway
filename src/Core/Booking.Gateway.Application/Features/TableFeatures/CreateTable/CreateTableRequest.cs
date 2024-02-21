using Booking.Gateway.Application.Models.Table;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.CreateTable;

public sealed record CreateTableRequest : BaseTableDto, IRequest<CreateTableResponse> { }