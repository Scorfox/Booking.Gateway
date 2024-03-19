using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTable;

public sealed record GetTableRequest : RequestById, IRequest<GetTableResponse>;