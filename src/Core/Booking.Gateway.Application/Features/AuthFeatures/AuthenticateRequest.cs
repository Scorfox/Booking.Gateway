using MediatR;

namespace Booking.Gateway.Application.Features.AuthFeatures;

public sealed record AuthenticateRequest : IRequest<AuthenticateResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
}