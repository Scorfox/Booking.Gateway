using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Company;

public class UpdateCompanyRequestExamples : IMultipleExamplesProvider<UpdateCompanyRequest>
{
    public IEnumerable<SwaggerExample<UpdateCompanyRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "UpdateCompanyExample1",
            new UpdateCompanyRequest
            {
                Id = Guid.NewGuid(),
                Name = "TestCompany1",
                Inn = "TestInn1",
                Description = "TestDescription1",
                MainAddress = "TestMainAddress1"
            });
        
        yield return SwaggerExample.Create(
            "UpdateCompanyExample2",
            new UpdateCompanyRequest
            {
                Id = Guid.NewGuid(),
                Name = "TestCompany2",
                Inn = "TestInn2",
                Description = "TestDescription2",
                MainAddress = "TestMainAddress2"
            });
    }
}