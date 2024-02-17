using Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Filial;

public class CreateFilialRequestExamples : IMultipleExamplesProvider<CreateFilialRequest>
{
    public IEnumerable<SwaggerExample<CreateFilialRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "CreateFilialExample1",
            new CreateFilialRequest
            {
                CompanyId = Guid.NewGuid(),
                Address = "TestAddress1",
                Name = "TestFilial1",
                Description = "TestDescription1",
            });
        
        yield return SwaggerExample.Create(
            "CreateFilialExample2",
            new CreateFilialRequest
            {
                CompanyId = Guid.NewGuid(),
                Address = "TestAddress2",
                Name = "TestFilial2",
                Description = "TestDescription2",
            });
    }
}