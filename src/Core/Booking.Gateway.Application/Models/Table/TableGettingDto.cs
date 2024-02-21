namespace Booking.Gateway.Application.Models.Table;

public record TableGettingDto : BaseTableDto
{
    public Guid Id { get; set; }
}