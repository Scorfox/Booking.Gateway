using Booking.Gateway.Application.Models.Filial;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Responses;

public class FilialGettingExamples : IMultipleExamplesProvider<FilialGettingDto>
{
    public IEnumerable<SwaggerExample<FilialGettingDto>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "TestFilial1",
            new FilialGettingDto
            {
                Id = Guid.NewGuid(),
                CompanyId = Guid.NewGuid(),
                Address = "TestAddress1",
                Name = "TestFilial1",
                Description = "TestDescription1",
            });
        
        yield return SwaggerExample.Create(
            "TestFilial2",
            new FilialGettingDto
            {
                Id = Guid.NewGuid(),
                CompanyId = Guid.NewGuid(),
                Address = "TestAddress2",
                Name = "TestFilial2",
                Description = "TestDescription2",
            });
    }
}