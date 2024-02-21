using Booking.Gateway.Application.Models.Filial;
using MediatR;

namespace Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;

public sealed record CreateFilialRequest : BaseFilialDto, IRequest<CreateFilialResponse> { }