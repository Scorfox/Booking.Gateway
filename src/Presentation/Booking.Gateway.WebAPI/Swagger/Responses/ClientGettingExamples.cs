using Booking.Gateway.Application.Models.Client;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Responses;

public class ClientGettingExamples : IMultipleExamplesProvider<ClientGettingDto>
{
    public IEnumerable<SwaggerExample<ClientGettingDto>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "TestClient1",
            new ClientGettingDto
            {
                Id = Guid.NewGuid(),
                Email = "ivanov@gmail.com",
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                PhoneNumber = "89112223344",
            });
        
        yield return SwaggerExample.Create(
            "TestClient2",
            new ClientGettingDto
            {
                Id = Guid.NewGuid(),
                Email = "kabanov@gmail.com",
                LastName = "Кабанов",
                FirstName = "Петр",
                MiddleName = "Петрович",
                PhoneNumber = "89112223355",
            });
    }
}