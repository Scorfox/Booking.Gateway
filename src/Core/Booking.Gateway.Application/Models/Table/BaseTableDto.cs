using Microsoft.AspNetCore.Mvc;

namespace Booking.Gateway.Application.Models.Table;

public abstract record BaseTableDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int SeatsNumber { get; set; }
}