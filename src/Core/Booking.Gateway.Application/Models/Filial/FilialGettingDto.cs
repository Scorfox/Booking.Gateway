namespace Booking.Gateway.Application.Models.Filial;

public record FilialGettingDto : BaseFilialDto
{
    public Guid Id { get; set; }
}