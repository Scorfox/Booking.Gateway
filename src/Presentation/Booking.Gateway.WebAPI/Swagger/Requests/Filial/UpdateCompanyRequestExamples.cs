using Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Filial;

public class UpdateFilialRequestExamples : IMultipleExamplesProvider<UpdateFilialRequest>
{
    public IEnumerable<SwaggerExample<UpdateFilialRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "UpdateFilialExample1",
            new UpdateFilialRequest
            {
                Id = Guid.NewGuid(),
                CompanyId = Guid.NewGuid(),
                Address = "TestAddress1",
                Name = "TestFilial1",
                Description = "TestDescription1",
            });
        
        yield return SwaggerExample.Create(
            "UpdateFilialExample2",
            new UpdateFilialRequest
            {
                Id = Guid.NewGuid(),
                Address = "TestAddress2",
                Name = "TestFilial2",
                Description = "TestDescription2",
            });
    }
}