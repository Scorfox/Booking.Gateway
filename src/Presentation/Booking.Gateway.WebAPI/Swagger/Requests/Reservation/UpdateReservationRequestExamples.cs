using Booking.Gateway.Application.Features.ReservationFeatures.UpdateReservation;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Reservation;

public class UpdateReservationRequestExamples : IMultipleExamplesProvider<UpdateReservationRequest>
{
    public IEnumerable<SwaggerExample<UpdateReservationRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "UpdateReservationExample1",
            new UpdateReservationRequest
            {
                Id = Guid.NewGuid(),
                TableId = Guid.NewGuid(),
                From = DateTimeOffset.Now,
                To = DateTimeOffset.Now.AddHours(3),
                WhoBookedId = Guid.NewGuid(),
            });
        
        yield return SwaggerExample.Create(
            "UpdateReservationExample2",
            new UpdateReservationRequest
            {
                Id = Guid.NewGuid(),
                TableId = Guid.NewGuid(),
                From = DateTimeOffset.Now,
                To = DateTimeOffset.Now.AddHours(3),
                WhoBookedId = Guid.NewGuid(),
            });
    }
}