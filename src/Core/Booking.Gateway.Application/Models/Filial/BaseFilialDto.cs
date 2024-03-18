using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Models.Filial;

public abstract record BaseFilialDto
{
    [FromRoute]
    public Guid CompanyId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string? Description { get; set; }
}