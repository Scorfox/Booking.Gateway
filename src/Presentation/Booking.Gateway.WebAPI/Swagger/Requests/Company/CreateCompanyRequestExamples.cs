using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Company;

public class CreateCompanyRequestExamples : IMultipleExamplesProvider<CreateCompanyRequest>
{
    public IEnumerable<SwaggerExample<CreateCompanyRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "CreateCompanyExample1",
            new CreateCompanyRequest
            {
                Name = "TestCompany1",
                Inn = "TestInn1",
                Description = "TestDescription1",
                MainAddress = "TestMainAddress1"
            });
        
        yield return SwaggerExample.Create(
            "CreateCompanyExample2",
            new CreateCompanyRequest
            {
                Name = "TestCompany2",
                Inn = "TestInn2",
                Description = "TestDescription2",
                MainAddress = "TestMainAddress2"
            });
    }
}