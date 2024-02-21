using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTables;

public sealed class GetTablesHandler : IRequestHandler<GetTablesRequest, GetTablesResponse>
{
    private readonly IMapper _mapper;

    public GetTablesHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetTablesResponse> Handle(GetTablesRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetTablesResponse();
    }
}