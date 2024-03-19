using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Common;

public abstract record RequestById
{
    [FromRoute]
    public Guid Id { get; set; }
}