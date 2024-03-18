using Booking.Gateway.Application.Features.TableFeatures.UpdateTable;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Table;

public class UpdateTableRequestExamples : IMultipleExamplesProvider<UpdateTableRequest>
{
    public IEnumerable<SwaggerExample<UpdateTableRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "UpdateTableExample1",
            new UpdateTableRequest
            {
                Id = Guid.NewGuid(),
                Name = "TestTable1",
                Description = "TestTableDescription1",
                SeatsNumber = 4
            });
        
        yield return SwaggerExample.Create(
            "UpdateTableExample2",
            new UpdateTableRequest
            {
                Id = Guid.NewGuid(),
                Name = "TestTable2",
                Description = "TestTableDescription2",
                SeatsNumber = 6
            });
    }
}