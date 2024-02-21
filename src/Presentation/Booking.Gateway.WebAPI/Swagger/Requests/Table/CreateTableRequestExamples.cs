using Booking.Gateway.Application.Features.TableFeatures.CreateTable;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Requests.Table;

public class CreateTableRequestExamples : IMultipleExamplesProvider<CreateTableRequest>
{
    public IEnumerable<SwaggerExample<CreateTableRequest>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "CreateTableExample1",
            new CreateTableRequest
            {
                FilialId = Guid.NewGuid(),
                Name = "TestTable1",
                Description = "TestTableDescription1",
                SeatsNumber = 4
            });
        
        yield return SwaggerExample.Create(
            "CreateTableExample2",
            new CreateTableRequest
            {
                FilialId = Guid.NewGuid(),
                Name = "TestTable2",
                Description = "TestTableDescription2",
                SeatsNumber = 6
            });
    }
}