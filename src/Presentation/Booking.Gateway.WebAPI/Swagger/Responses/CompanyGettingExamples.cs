using Booking.Gateway.Application.Models.Company;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Responses;

public class CompanyGettingExamples : IMultipleExamplesProvider<CompanyGettingDto>
{
    public IEnumerable<SwaggerExample<CompanyGettingDto>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "TestCompany1",
            new CompanyGettingDto
            {
                Id = Guid.NewGuid(),
                Name = "TestCompany1",
                Inn = "TestInn1",
                Description = "TestDescription1",
                MainAddress = "TestMainAddress1"
            });
        
        yield return SwaggerExample.Create(
            "TestCompany2",
            new CompanyGettingDto
            {
                Id = Guid.NewGuid(),
                Name = "TestCompany2",
                Inn = "TestInn2",
                Description = "TestDescription2",
                MainAddress = "TestMainAddress2"
            });
    }
}