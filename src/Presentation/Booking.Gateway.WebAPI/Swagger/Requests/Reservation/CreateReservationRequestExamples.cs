using Booking.Gateway.Application.Features.ReservationFeatures.CreateReservation;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Reservation;

public class CreateReservationRequestExamples : IMultipleExamplesProvider<CreateReservationRequest>
{
    public IEnumerable<SwaggerExample<CreateReservationRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "CreateReservationExample1",
            new CreateReservationRequest
            {
                TableId = Guid.NewGuid(),
                From = DateTimeOffset.Now,
                To = DateTimeOffset.Now.AddHours(3),
                WhoBookedId = Guid.NewGuid(),
            });
        
        yield return SwaggerExample.Create(
            "CreateReservationExample2",
            new CreateReservationRequest
            {
                TableId = Guid.NewGuid(),
                From = DateTimeOffset.Now.AddHours(2),
                To = DateTimeOffset.Now.AddHours(4),
                WhoBookedId = Guid.NewGuid(),
            });
    }
}