using Booking.Gateway.Application.Features.ClientFeatures.CreateClient;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Client;

public class CreateClientRequestExamples : IMultipleExamplesProvider<CreateClientRequest>
{
    public IEnumerable<SwaggerExample<CreateClientRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "CreateUserExample1",
            new CreateClientRequest
            {
                Email = "ivanov@gmail.com",
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                PhoneNumber = "89112223344",
                Password = "It's very StRoNg PassW0rd!1!"
            });
        
        yield return SwaggerExample.Create(
            "CreateUserExample2",
            new CreateClientRequest
            {
                Email = "kabanov@gmail.com",
                LastName = "Кабанов",
                FirstName = "Петр",
                MiddleName = "Петрович",
                PhoneNumber = "89112223355",
                Password = "It's very StRoNg PassW0rd!2!"
            });
    }
}