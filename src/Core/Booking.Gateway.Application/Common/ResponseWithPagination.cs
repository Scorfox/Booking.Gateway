namespace Booking.Gateway.Application.Common;

public record class ResponseWithPagination<T>
{
    public int Offset { get; set; }
    public int Count { get; set; }
    public int TotalCount { get; set; }
    public List<T> Items { get; set; }
}