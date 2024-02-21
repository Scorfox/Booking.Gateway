using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.DeleteTable;

public sealed record DeleteTableRequest : RequestById, IRequest<DeleteTableResponse> { }