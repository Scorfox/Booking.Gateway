using Booking.Gateway.Application.Features.ClientFeatures.UpdateClient;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests;

public class UpdateClientRequestExamples : IMultipleExamplesProvider<UpdateClientRequest>
{
    public IEnumerable<SwaggerExample<UpdateClientRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "UpdateUserExample1",
            new UpdateClientRequest
            {
                Email = "ivanov2@gmail.com",
                LastName = "Иванов",
                FirstName = "Федор",
                MiddleName = "Иванович",
                PhoneNumber = "89112223344",
                Password = "It's very StRoNg PassW0rd!1!"
            });
        
        yield return SwaggerExample.Create(
            "UpdateUserExample2",
            new UpdateClientRequest
            {
                Email = "kabanov2@gmail.com",
                LastName = "Кабанов",
                FirstName = "Василий",
                MiddleName = "Петрович",
                PhoneNumber = "89112223355",
                Password = "It's very StRoNg PassW0rd!2!"
            });
    }
}